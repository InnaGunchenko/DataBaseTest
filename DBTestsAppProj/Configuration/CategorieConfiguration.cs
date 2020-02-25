using DBTestsAppProj.Extensions;
using DBTestsAppProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBTestsAppProj.Configuration
{
    class CategorieConfiguration : DbEntityConfiguration<Categorie>
    {
        public override void Configuration(EntityTypeBuilder<Categorie> modelBuilder)
        {
            modelBuilder.HasKey(e => e.CategoryId)
                    .HasName("PK__categori__D54EE9B4995CE707");
            modelBuilder.ToTable("categories", "production");
            modelBuilder.Property(e => e.CategoryId).HasColumnName("category_id");
            modelBuilder.Property(e => e.CategoryName)
                .IsRequired()
                .HasColumnName("category_name")
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
