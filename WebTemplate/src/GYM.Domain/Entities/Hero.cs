using System;
using System.Collections.Generic;

namespace GYM.Domain.Entities
{
  public class Hero
  {
    public Hero()
    {
      HeroId = Guid.NewGuid();
      Itens = new List<Item>();
    }

    public bool IsValid() {
      return true;
    }

    public Guid HeroId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public virtual ICollection<Item> Itens { get; set; }
    public virtual Pet Pet { get; set; }
    public virtual Guild Guild { get; set; }
    public bool Deleted { get; set; }
    public DateTime DeletedOn { get; set; }
  }
}
