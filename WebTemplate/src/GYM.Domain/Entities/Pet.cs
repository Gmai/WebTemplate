using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYM.Domain.Entities
{
  public class Pet
  {
    public Pet()
    {
      PetId = Guid.NewGuid();
    }

    public bool IsValid() {
      return true;
    }

    [ForeignKey("Hero")]
    public Guid PetId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public virtual Hero Hero { get; set; }
    public bool Deleted { get; set; }
    public DateTime DeletedOn { get; set; }
  }
}
