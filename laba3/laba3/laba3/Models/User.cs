using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace laba3.Models
{
    public class User
    {
        [Display(Name = "Имя")]
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Телефон")]
        [Required]
        [MinLength(6)]
        [MaxLength(11)]
        public string Phone { get; set; }
    }
}