using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CRUDAPPLICATION.ViewModel
{
    public class UserViewModel
    {
        [Display(Name = "UserName"), Required(ErrorMessage = "UserName is Required"), StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string UserName { get; set; } 
       
        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Password")]
        [StringLength(24, MinimumLength = 6, ErrorMessage = "Address must contains 6-24 character ")]
        [DataType(DataType.Password)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Passwords must contain upper case (a-z), lower case (A-Z), number (0-9) ")]
        public string UserPassword { get; set; }
        [Required(ErrorMessage = "Please enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("UserPassword")]
        public string ConfirmPassword { get; set; }

        [EmailAddress, Display(Name = "Email"), Required(ErrorMessage = "Email is Required"), StringLength(40, MinimumLength = 10, ErrorMessage = "Between 10 to 40 Character .")]
        public string? Email { get; set; }
    }
}
