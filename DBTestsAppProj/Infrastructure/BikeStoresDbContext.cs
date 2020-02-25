using DBTestsAppProj.Configuration;
using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DBTestsAppProj.Infrastructure
{
    public class BikeStoresDbContext : DbContext
    {
        public BikeStoresDbContext() { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BikeStoresDbContext"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.AddConfiguration(new BrandConfiguration());
            modelBuilder.AddConfiguration(new CategorieConfiguration());
            modelBuilder.AddConfiguration(new CustomerConfiguration());
            modelBuilder.AddConfiguration(new OrderConfiguration());
            modelBuilder.AddConfiguration(new OrderItemConfiguration());
            modelBuilder.AddConfiguration(new ProductConfiguration());
            modelBuilder.AddConfiguration(new StaffConfiguration());
            modelBuilder.AddConfiguration(new StockConfiguration());
            modelBuilder.AddConfiguration(new StoreConfiguration());
        }
    }
}
