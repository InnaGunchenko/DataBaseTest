using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class OrderItemConfiguration : DbEntityConfiguration<OrderItem>
    {
        public override void Configuration(EntityTypeBuilder<OrderItem> modelBuilder)
        {
            modelBuilder.HasKey(e => new { e.OrderId, e.ItemId })
                    .HasName("PK__order_it__837942D472925D6B");

            modelBuilder.ToTable("order_items", "sales");

            modelBuilder.Property(e => e.OrderId).HasColumnName("order_id");

            modelBuilder.Property(e => e.ItemId).HasColumnName("item_id");

            modelBuilder.Property(e => e.Discount)
                .HasColumnName("discount")
                .HasColumnType("decimal(4, 2)");

            modelBuilder.Property(e => e.ListPrice)
                .HasColumnName("list_price")
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Property(e => e.ProductId).HasColumnName("product_id");

            modelBuilder.Property(e => e.Quantity).HasColumnName("quantity");

            modelBuilder.HasOne(d => d.Order)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_ite__order__571DF1D5");

            modelBuilder.HasOne(d => d.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__order_ite__produ__5812160E");
        }
    }
}
