using DB.Configurations;
using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DB.Contexts
{
    public class BazarStoreDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Connection String");

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
