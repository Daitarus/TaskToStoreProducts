namespace RepositoryDB
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        IQueryable<T> SelectAll();
        void SaveChanges();
    }
}
