using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Infrastructure.Data.EntityConfig
{
  public class GuildConfig:EntityTypeConfiguration<Guild>
  { 
    public GuildConfig() {
      HasKey(x => x.GuildId);
      Property(x => x.Name).HasMaxLength(50).IsRequired();
      Property(x => x.CreatedOn).IsRequired();
      Property(x => x.DeletedOn).IsRequired();
      ToTable("Guilds");
    }
  }
}
