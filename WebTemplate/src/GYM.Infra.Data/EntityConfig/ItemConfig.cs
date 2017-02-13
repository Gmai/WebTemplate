using GYM.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace GYM.Infra.Data.EntityConfig
{
    public class ItemConfig: EntityTypeConfiguration<Item>
    {
        public ItemConfig() {
            HasKey(x => x.itemId);
            Property(x => x.name).IsRequired().HasMaxLength(20);
            ToTable("itens");
        }
    }
}
