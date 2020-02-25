using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class StoreConfiguration : DbEntityConfiguration<Store>
    {
        public override void Configuration(EntityTypeBuilder<Store> modelBuilder)
        {
            modelBuilder.HasKey(e => e.StoreId)
                    .HasName("PK__stores__A2F2A30C8CB2AFBE");

            modelBuilder.ToTable("stores", "sales");

            modelBuilder.Property(e => e.StoreId).HasColumnName("store_id");

            modelBuilder.Property(e => e.City)
                .HasColumnName("city")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            modelBuilder.Property(e => e.State)
                .HasColumnName("state")
                .HasMaxLength(10)
                .IsUnicode(false);

            modelBuilder.Property(e => e.StoreName)
                .IsRequired()
                .HasColumnName("store_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Street)
                .HasColumnName("street")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.ZipCode)
                .HasColumnName("zip_code")
                .HasMaxLength(5)
                .IsUnicode(false);
        }
    }
}
