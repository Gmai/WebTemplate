using System;
using System.Collections.Generic;

namespace GYM.Domain.Entities
{
    public class Hero
    {
        public Hero()
        {
            heroId = Guid.NewGuid();
        }

        public Guid heroId { get; set; }
        public string name { get; set; }
        public DateTime createdOn { get; set; }
        public virtual ICollection<Item> itens { get; set; }
        public bool isDeleted { get; set; }
        public DateTime deletedOn { get; set; }
    }
}
