using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class OrderConfiguration : DbEntityConfiguration<Order>
    {
        public override void Configuration(EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder.HasKey(e => e.OrderId)
                    .HasName("PK__orders__4659622928CE8B2F");

            modelBuilder.ToTable("orders", "sales");

            modelBuilder.Property(e => e.OrderId).HasColumnName("order_id");

            modelBuilder.Property(e => e.CustomerId).HasColumnName("customer_id");

            modelBuilder.Property(e => e.OrderDate)
                .HasColumnName("order_date")
                .HasColumnType("date");

            modelBuilder.Property(e => e.OrderStatus).HasColumnName("order_status");

            modelBuilder.Property(e => e.RequiredDate)
                .HasColumnName("required_date")
                .HasColumnType("date");

            modelBuilder.Property(e => e.ShippedDate)
                .HasColumnName("shipped_date")
                .HasColumnType("date");

            modelBuilder.Property(e => e.StaffId).HasColumnName("staff_id");

            modelBuilder.Property(e => e.StoreId).HasColumnName("store_id");

            modelBuilder.HasOne(d => d.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__orders__customer__5165187F");

            modelBuilder.HasOne(d => d.Staff)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orders__staff_id__534D60F1");

            modelBuilder.HasOne(d => d.Store)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__orders__store_id__52593CB8");
        }
    }
}
