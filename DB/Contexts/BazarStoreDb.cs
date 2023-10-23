using DB.Configurations;
using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DB.Contexts
{
    public class BazarStoreDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0125-10;Database=BazarDB;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Product> Products { get; set; }
    
    }
}
