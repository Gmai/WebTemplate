using GYM.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Infrastructure.Data.EntityConfig
{
  public class PetConfig : EntityTypeConfiguration<Pet>
  {
    public PetConfig()
    {
      HasKey(c => c.PetId);
      Property(c => c.Name)
          .IsRequired()
          .HasMaxLength(50)
          .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
      Property(x => x.Name).HasMaxLength(50).IsRequired();
      Property(x => x.CreatedOn).IsRequired();
      Property(x => x.DeletedOn).IsRequired();
      ToTable("Pets");
    }
  }
}
