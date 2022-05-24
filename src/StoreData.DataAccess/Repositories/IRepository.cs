namespace StoreData.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);

        void Update(T item);

        void Remove(T item);

        void SaveChanges();
    }
}
