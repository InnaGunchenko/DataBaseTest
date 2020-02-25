using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class ProductConfiguration : DbEntityConfiguration<Product>
    {
        public override void Configuration(EntityTypeBuilder<Product> modelBuilder)
        {
            modelBuilder.HasKey(e => e.ProductId)
                    .HasName("PK__products__47027DF5143D52D9");

            modelBuilder.ToTable("products", "production");

            modelBuilder.Property(e => e.ProductId).HasColumnName("product_id");

            modelBuilder.Property(e => e.BrandId).HasColumnName("brand_id");

            modelBuilder.Property(e => e.CategoryId).HasColumnName("category_id");

            modelBuilder.Property(e => e.ListPrice)
                .HasColumnName("list_price")
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Property(e => e.ModelYear).HasColumnName("model_year");

            modelBuilder.Property(e => e.ProductName)
                .IsRequired()
                .HasColumnName("product_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.HasOne(d => d.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__products__brand___45F365D3");

            modelBuilder.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__products__catego__44FF419A");
        }
    }
}