using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace laba4.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
    }
}