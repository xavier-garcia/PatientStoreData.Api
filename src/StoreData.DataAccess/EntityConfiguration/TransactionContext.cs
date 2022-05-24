using Microsoft.EntityFrameworkCore;

namespace StoreData.DataAccess.EntityConfiguration
{
    public class TransactionContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "Patients";

        public TransactionContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<T> GetSet<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}