using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel
{
    public class HeroVM
    {
        public HeroVM()
        {
            heroId = Guid.NewGuid();
        }

        [Key]
        public Guid heroId { get; set; }

        [Display(Name = "Name")]
        [MaxLength(100, ErrorMessage = "Max {0} caracters")]
        [MinLength(5, ErrorMessage = "Min {0} caracters")]
        public string name { get; set; }

        [Display(Name="Created On")]
        [DataType(DataType.Date, ErrorMessage ="Date in wrong format")]
        public DateTime createdOn { get; set; }

        public ICollection<ItemVM> itens { get; set; }

        [ScaffoldColumn(false)]
        public bool isDeleted { get; set; }

        [ScaffoldColumn(false)]
        public DateTime dateDeleted { get; set; }
    }
}
