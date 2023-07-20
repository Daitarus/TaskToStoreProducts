using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    internal class ObjectRepository : Repository<ObjectEntity>
    {
        public ObjectRepository(ProductDB dataBase) : base(dataBase) { }
    }
}
