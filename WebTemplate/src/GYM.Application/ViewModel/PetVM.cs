using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GYM.Application.ViewModel
{
    public class PetVM
    {
        public PetVM()
        {
            PetId = Guid.NewGuid();
        }

        [Key]
        public Guid PetId { get; set; }

        [Display(Name = "Name")]
        [MaxLength(100, ErrorMessage = "Max {0} caracters")]
        [MinLength(5, ErrorMessage = "Min {0} caracters")]
        public string Name { get; set; }

        [Display(Name="Created On")]
        [DataType(DataType.Date, ErrorMessage ="Date in wrong format")]
        public DateTime CreatedOn { get; set; }

        public ICollection<ItemVM> itens { get; set; }

        [ScaffoldColumn(false)]
        public bool Deleted { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DeletedOn { get; set; }
    }
}
