using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class CustomerConfiguration : DbEntityConfiguration<Customer>
    {
        public override void Configuration(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder.HasKey(e => e.CustomerId)
                    .HasName("PK__customer__CD65CB856EED4A51");

            modelBuilder.ToTable("customers", "sales");

            modelBuilder.Property(e => e.CustomerId).HasColumnName("customer_id");

            modelBuilder.Property(e => e.City)
                .HasColumnName("city")
                .HasMaxLength(50)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            modelBuilder.Property(e => e.State)
                .HasColumnName("state")
                .HasMaxLength(25)
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
