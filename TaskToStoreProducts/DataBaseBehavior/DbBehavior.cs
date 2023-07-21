using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBaseBehavior
{   
    internal class DbBehavior
    {
        private Action<string> printSystemMessageCallback;
        public ProductDB? database { get; private set; }
        public DbBehavior(Action<string> printSystemMessageCallback)
        {
            this.printSystemMessageCallback = printSystemMessageCallback;
        }

        public bool TryConnectDb()
        {
            string connectionString;
            if(TryGetConnectionString("ConnectionString", out connectionString))
            {
                try
                {
                    database = new ProductDB(connectionString);
                    printSystemMessageCallback("База данных подключена...");
                    return true;
                }
                catch (Exception ex)
                {
                    //TODO logger
                }
            }
            printSystemMessageCallback("Ошибка: База данных не подключена!");
            return false;
        }
        public bool TryConvertDatabaseToXML()
        {
            string connectionString, fileName;
            if (TryGetConnectionString("ConnectionString", out connectionString) && TryGetFileName("XmlFileName", out fileName))
            {
                string sqlSqript1 = $"select * from {nameof(database.Objects)} for xml auto";
                string sqlSqript2 = $"select * from {nameof(database.Attributes)} for xml auto";
                string sqlSqript3 = $"select * from {nameof(database.ObjectRelationships)} for xml auto";
                string xml;
                if (TryGetXMLFromDataBase(connectionString, out xml, sqlSqript1, sqlSqript2, sqlSqript3))
                {
                    File.WriteAllText(fileName, xml);
                    printSystemMessageCallback("XML базы данных записан в файла...");
                }
            }
            return false;
        }

        private bool TryGetXMLFromDataBase(string connectionString, out string xml, params string[] sqlScripts)
        {
            xml = string.Empty;
            try
            {
                xml = GetXMLFromDataBase(connectionString, sqlScripts);
                printSystemMessageCallback("XML базы данных получен...");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private string GetXMLFromDataBase(string connectionString, params string[] sqlScripts)
        {
            string xml = string.Empty;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            foreach (string sqlScript in sqlScripts)
            {
                using (SqlCommand cmd = new SqlCommand(sqlScript, sqlConnection))
                {
                    xml += (string)cmd.ExecuteScalar();
                    xml += "\r\n";
                }
            }
            sqlConnection.Close();
            return xml;
        }

        private bool TryGetConnectionString(string key, out string? connectionString)
        {
            connectionString = ConfigurationManager.AppSettings[key];
            bool result = !String.IsNullOrEmpty(connectionString);
            if (result)
                printSystemMessageCallback("Строка подключения к базе данных успешно получена из конфигурационного файла..."); 
            else
                printSystemMessageCallback("Ошибка: Строка для подключения к базе данных не получена из конфигурационного файла!");
            return result;
        }
        private bool TryGetFileName(string key, out string? fileName)
        {
            fileName = ConfigurationManager.AppSettings[key];
            bool result = !String.IsNullOrEmpty(fileName);
            if(result)
                printSystemMessageCallback("Имя файла было получено из конфигурационного файла...");
            else
                printSystemMessageCallback("Ошибка: Имя файла не получено из конфигурационного файла!");
            return result;
        }

        public bool IsArgumentNullOrEmpty(params string[] arguments)
        {
            bool result = false;
            foreach (var arument in arguments)
            {
                result = result || String.IsNullOrEmpty(arument);
            }
            return result;
        }
        public bool IsArgumentNullOrEmptyWithPrintError(params string[] arguments)
        {
            bool result = IsArgumentNullOrEmpty(arguments);
            if(result)
                printSystemMessageCallback("Ошибка: Должны быть заполнены все поля!");
            return result;
        }
        public bool IsDataBaseNullWithPrintError()
        {
            bool result = database == null;
            if(result)
                printSystemMessageCallback("Ошибка: Действие невозможно, база данных не подключена!");
            return result;
        }
        public bool IsEntityNullWithPrintError(Entity? entity)
        {
            bool result = entity == null;
            if(result)
                printSystemMessageCallback($"Ошибка: Сущность с таким {nameof(entity.Id)} не найдено!");
            return result;
        }
        public bool IsIdsEqualWithPrintError(long id1, long id2)
        {
            bool result = id1 == id2;
            if(result)
                printSystemMessageCallback($"Ошибка: Сущность не может быть связана сама с собой!");
            return result;
        }
        public bool TryParseToId(string str, out long id)
        {
            bool result = long.TryParse(str, out id);
            if(!result)
                printSystemMessageCallback("Ошибка: Невозможно преобразовать строку в Id");
            return result;
        }
        public bool TrySaveChangeIntoDB(AbstractRepository repository)
        {
            try
            {
                repository.SaveChanges();
                printSystemMessageCallback("База данных успешно изменена...");
                return true;
            }
            catch (DbUpdateException ex)
            {
                //TODO logger
                printSystemMessageCallback("Ошибка: Сохранение изменений базы данных не выполнено!");
                return false;
            }
        }

        public void DisposeDataBase()
        {
            if (database != null)
            {
                database.Dispose();
                printSystemMessageCallback("База данных отключена...");
            }
        }
    }
}
