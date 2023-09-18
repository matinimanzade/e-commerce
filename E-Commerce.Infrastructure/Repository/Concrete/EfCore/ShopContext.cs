using E_Commerce.
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure.Repository.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource = shop_db");
        }

        //Aşağıdakı metod ProductCategory modelindəki primaryKeyləri yapılandırır
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c => new {c.ProductId, c.CategoryId});

        }
    }
}
