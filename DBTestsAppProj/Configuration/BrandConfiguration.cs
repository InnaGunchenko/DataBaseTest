using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    public class BrandConfiguration : DbEntityConfiguration<Brand>
    {
        public override void Configuration(EntityTypeBuilder<Brand> modelBuilder)
        {
            modelBuilder.HasKey(e => e.BrandId)
                .HasName("PK__brands__5E5A8E27C1522ED0");
            modelBuilder.ToTable("brands", "production");
            modelBuilder.Property(e => e.BrandId)
                .HasColumnName("brand_id");
            modelBuilder.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("brand_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
        }
    }
}
