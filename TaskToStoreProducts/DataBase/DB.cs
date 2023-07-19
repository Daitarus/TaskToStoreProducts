using Microsoft.EntityFrameworkCore;
using System.Text;

namespace TaskToStoreProducts.DataBase
{
    public class DB : DbContext
    {
        public readonly string connectionString;

        public DB(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        public DB(string connectionString, string createTablesScript)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.connectionString = connectionString;
            if (Database.EnsureCreated() && !String.IsNullOrEmpty(createTablesScript))
                Database.ExecuteSqlRaw(createTablesScript);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public static bool CheckOrCreateDB(string connectionString)
        {
            return CheckOrCreateDB(connectionString, String.Empty);
        }

        public static bool CheckOrCreateDB(string connectionString, string createTablesScript)
        {
            try
            {
                using (new DB(connectionString, createTablesScript)) { }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GetSqlScript(string fileText)
        {
            string sqlScript = String.Empty;

            if (!String.IsNullOrEmpty(fileText))
            {
                FileInfo fileInfo = new FileInfo(fileText);
                if (fileInfo.Exists)
                {
                    byte[] sqlScriptBytes = new byte[fileInfo.Length];
                    using (FileStream fstream = System.IO.File.Open(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        fstream.Read(sqlScriptBytes);
                    }
                    sqlScript = Encoding.UTF8.GetString(sqlScriptBytes);
                }
            }

            return sqlScript;
        }
    }
}
