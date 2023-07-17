namespace RepositoryDB
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected DataBase database;
        public Repository(DataBase database)
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
