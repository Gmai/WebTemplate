using System;

namespace GYM.Domain.Entities
{
  public class Item
  {
    public Item()
    {
      ItemId = Guid.NewGuid();
    }

    public Guid ItemId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Deleted { get; set; }
    public DateTime DeletedOn { get; set; }
  }
}
