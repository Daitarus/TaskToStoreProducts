using TaskToStoreProducts.DataBase.Repositories;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    public class Repository<T> where T : Entity
    {
        protected DB database;
        public Repository(DB database)
        {
            this.database = database;
        }

        public T? SelectForId(uint id)
        {
            return database.Find<T>(id);
        }
        public void Add(T entity)
        {
            database.Add(entity);
        }        
        public void Remove(T entity)
        {
            database.Remove(entity);
        }
        public IQueryable<T> SelectAll()
        {
            return database.Set<T>();
        }
        public void SaveChanges()
        {
            database.SaveChanges();
        }
    }
}
