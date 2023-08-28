using E_Commerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repository.Concrete.EfCore
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
