using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Application.ViewModel
{
  public class ItemVM
  {
    [Key]
    public Guid heroId { get; set; }

    [Display(Name = "Name")]
    [MaxLength(100, ErrorMessage = "Max {0} caracters")]
    [MinLength(5, ErrorMessage = "Min {0} caracters")]
    public string name { get; set; }
  }
}
