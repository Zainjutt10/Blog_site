using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment03.Models
{
    public class Login
    {
        [Required (ErrorMessage ="Enter name*")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Enter password")]
        public string Password { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public bool admin { get; set; }

    }
}
