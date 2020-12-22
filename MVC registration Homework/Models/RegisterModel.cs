using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_registration_Homework.Models
{
    public class RegisterModel
    {   
        [Required]
        public string UserName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
