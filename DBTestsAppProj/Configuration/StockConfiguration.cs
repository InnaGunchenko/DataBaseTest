using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class StockConfiguration : DbEntityConfiguration<Stock>
    {
        public override void Configuration(EntityTypeBuilder<Stock> modelBuilder)
        {
            modelBuilder.HasKey(e => new { e.StoreId, e.ProductId })
                    .HasName("PK__stocks__E68284D3CB4E6589");

            modelBuilder.ToTable("stocks", "production");

            modelBuilder.Property(e => e.StoreId).HasColumnName("store_id");

            modelBuilder.Property(e => e.ProductId).HasColumnName("product_id");

            modelBuilder.Property(e => e.Quantity).HasColumnName("quantity");

            modelBuilder.HasOne(d => d.Product)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__stocks__product___5BE2A6F2");

            modelBuilder.HasOne(d => d.Store)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__stocks__store_id__5AEE82B9");
        }
    }
}
