using Microsoft.EntityFrameworkCore;
using System.Text;

namespace TaskToStoreProducts.DataBase
{
    public class DB : DbContext
    {
        public string ConnectionString { get; }
        public bool WasCreated { get; }

        public DB(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));
            ConnectionString = connectionString;

            WasCreated = Database.EnsureCreated();
        }
        public DB(string connectionString, string createTablesScript)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));
            ConnectionString = connectionString;

            WasCreated = Database.EnsureCreated();

            if (WasCreated && !String.IsNullOrEmpty(createTablesScript))
                Database.ExecuteSqlRaw(createTablesScript);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
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
