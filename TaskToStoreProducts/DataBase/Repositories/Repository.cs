using TaskToStoreProducts.DataBase.Repositories;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    public class Repository<T> : AbstractRepository where T : Entity 
    {
        public Repository(DB database) : base(database) { }

        public virtual T? SelectForId(long id)
        {
            return database.Find<T>(id);
        }
        public virtual void Add(T entity)
        {
            database.Add(entity);
        }        
        public virtual void Delete(T entity)
        {
            database.Remove(entity);
        }
        public virtual IQueryable<T> SelectAll()
        {
            return database.Set<T>();
        }
    }
}
