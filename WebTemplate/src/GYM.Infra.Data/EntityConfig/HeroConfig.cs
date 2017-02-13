using GYM.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Infra.Data.EntityConfig
{
    public class HeroConfig:EntityTypeConfiguration<Hero>
    {

        public HeroConfig() {
            HasKey(c => c.heroId);
            Property(c => c.name)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique=true }));
            ToTable("heroes");
        }
    }
}
