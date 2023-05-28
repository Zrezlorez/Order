using Order.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Order.Database
{
    internal class Manager : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ChangeLog> ChangeLogs { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
       

        public Manager()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=storage;Username=postgres;Password=admin");
        }
    }
}
