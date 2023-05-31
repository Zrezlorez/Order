using Microsoft.EntityFrameworkCore;
using Order.Database.Model;

namespace Order.Database
{
    internal class Context : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ChangeLog> ChangeLogs { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;


        public Context()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseNpgsql("Host=localhost;Port=5432;Database=storage;Username=postgres;Password=admin");
        }
    }
}
