using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQLTelephoneDictionaryDLL
{
    public class Person
    {
        public int Id { get; set; }

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
