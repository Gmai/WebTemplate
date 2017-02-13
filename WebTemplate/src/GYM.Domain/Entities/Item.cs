using System;

namespace GYM.Domain.Entities
{
    public class Item
    {
        public Item() {
            itemId = Guid.NewGuid();
        }

        public Guid itemId { get; set; }
        public string name { get; set; }

    }
}
