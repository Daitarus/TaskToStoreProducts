using Microsoft.EntityFrameworkCore;
using System.Text;

namespace RepositoryDB
{
    public class DataBase : DbContext
    {
        public readonly string connectionString;

        public DataBase(string connectionString)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        public DataBase(string connectionString, string createTablesScript)
        {
            if(String.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            this.connectionString = connectionString;
            if (Database.EnsureCreated() && !String.IsNullOrEmpty(createTablesScript))
                Database.ExecuteSqlRaw(createTablesScript);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public static bool CheckOrCreateDB(string connectionString)
        {
            return CheckOrCreateDB(connectionString, String.Empty);
        }

        public static bool CheckOrCreateDB(string connectionString, string createTablesScript)
        {
            try
            {
                using (new DataBase(connectionString, createTablesScript)) { }
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
