using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using ProductCatalog.Data.Maps;

namespace ProductCatalog.Data
{
    public class StoreDataContext : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
        public DbSet<L_FUNCIONARIOS> L_FUNCIONARIOS { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info=True; Initial Catalog=EasyEPIDesenvolvimento; User ID=sa; password=IO2biVYJhh; Data Source=200.219.235.40,5001");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new ProductMap());
            //builder.ApplyConfiguration(new CategoryMap());
        }
    }
}