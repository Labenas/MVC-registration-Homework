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
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The First Name must be more than 3 and less than 20 characters.")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Name can't contain any digits and special symbols")]
        [Required(ErrorMessage = "Name field is empty, please enter the your first name.")]
        public string UserName { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Name can't contain any digits and special symbols")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The First Name must be more than 3 and less than 20 characters.")]
        [Required(ErrorMessage = "Last Name field is empty, please enter your last name.")]
        public string LastName { get; set; }

        [Range(1, 100, ErrorMessage = "Please enter the Age value between 1 and 100.")]
        [Required(ErrorMessage = "Age field is empty please enter your age")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        [Required(ErrorMessage = "Email adress is required field please enter your email")]
        public string Email { get; set; }

       
    }
}
