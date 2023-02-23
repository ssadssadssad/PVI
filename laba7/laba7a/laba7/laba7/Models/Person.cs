using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace laba7.Models
{
    public class Person
    {
        [Display(Name = "Name")]
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        [Required]
        [MinLength(6)]
        [MaxLength(12)]
        public string Phone { get; set; }
    }
}