using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class StaffConfiguration : DbEntityConfiguration<Staff>
    {
        public override void Configuration(EntityTypeBuilder<Staff> modelBuilder)
        {
            modelBuilder.HasKey(e => e.StaffId)
                    .HasName("PK__staffs__1963DD9CE9A447DF");

            modelBuilder.ToTable("staffs", "sales");

            modelBuilder.HasIndex(e => e.Email)
                .HasName("UQ__staffs__AB6E61649D61FDC8")
                .IsUnique();

            modelBuilder.Property(e => e.StaffId).HasColumnName("staff_id");

            modelBuilder.Property(e => e.Active).HasColumnName("active");

            modelBuilder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            modelBuilder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            modelBuilder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            modelBuilder.Property(e => e.ManagerId).HasColumnName("manager_id");

            modelBuilder.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            modelBuilder.Property(e => e.StoreId).HasColumnName("store_id");

            modelBuilder.HasOne(d => d.Manager)
                .WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__staffs__manager___4E88ABD4");

            modelBuilder.HasOne(d => d.Store)
                .WithMany(p => p.Staffs)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__staffs__store_id__4D94879B");
        }
    }
}
