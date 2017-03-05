using GYM.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace GYM.Infrastructure.Data.EntityConfig
{
  public class ItemConfig : EntityTypeConfiguration<Item>
  {
    public ItemConfig()
    {
      HasKey(x => x.ItemId);
      Property(x => x.Name).IsRequired().HasMaxLength(20);
      Property(x => x.CreatedOn).IsRequired();
      Property(x => x.DeletedOn).IsRequired();
      ToTable("Itens");
    }
  }
}
