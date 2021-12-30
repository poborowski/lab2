using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab2_test.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Data")]
        public DateTime Description { get; set; }
      
    }
}
