using Microsoft.EntityFrameworkCore;
using StoreData.DataAccess.EntityConfiguration;
using StoreData.DataAccess.Repositories;


namespace Voxel.Billback.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly TransactionContext transactionContext;

        public BaseRepository(TransactionContext transactionContext)
        {
            this.transactionContext = transactionContext;
        }

        public void Add(T item)
        {
            GetDbSet().Add(item);
        }

        public void Update(T item)
        {
            GetDbSet().Update(item);
        }

        public void Remove(T item)
        {
            GetDbSet().Remove(item);
        }

        public void SaveChanges()
        {
            this.transactionContext.SaveChanges();
        }

        protected DbSet<T> GetDbSet()
        {
            return transactionContext.GetSet<T>();
        }
    }
}
