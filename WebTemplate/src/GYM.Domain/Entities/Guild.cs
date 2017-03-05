using System;
using System.Collections.Generic;

namespace GYM.Domain.Entities
{
  public class Guild
  {
    public Guild()
    {
      GuildId = Guid.NewGuid();
    }

    public bool IsValid() {
      return true;
    }

    public Guid GuildId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Hero> Heroes { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Deleted { get; set; }
    public DateTime DeletedOn { get; set; }
  }
}
