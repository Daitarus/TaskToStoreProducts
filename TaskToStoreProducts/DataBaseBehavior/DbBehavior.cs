using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase;

namespace TaskToStoreProducts.DataBaseBehavior
{   
    internal class DbBehavior : IDisposable
    {
        private Action<string> printSystemMessageCallback;
        private ProductDB? database = null;
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

        public void Dispose()
        {
            if (database != null)
                database.Dispose();
        }
    }
}
