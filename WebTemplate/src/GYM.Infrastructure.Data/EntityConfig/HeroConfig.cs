using GYM.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Infrastructure.Data.EntityConfig
{
  public class HeroConfig : EntityTypeConfiguration<Hero>
  {

    public HeroConfig()
    {
      HasKey(c => c.HeroId);
      Property(c => c.Name)
          .IsRequired()
          .HasMaxLength(20)
          .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
      Property(x => x.CreatedOn).IsRequired();
      Property(x => x.DeletedOn).IsRequired();
      ToTable("Heroes");
    }
  }
}
