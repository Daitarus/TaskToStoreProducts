using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToStoreProducts.DataBase.Repositories
{
    public abstract class AbstractRepository
    {
        protected DB database;
        public AbstractRepository(DB database)
        {
            this.database = database;
        }

        public void SaveChanges()
        {
            database.SaveChanges();
        }
    }
}
