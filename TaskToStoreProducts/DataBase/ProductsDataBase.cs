using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryDB;

namespace TaskToStoreProducts.DataBase
{
    internal class ProductsDataBase : RepositoryDB.DataBase
    {
        public ProductsDataBase(string connectionString) : base(connectionString) { }
    }
}
