using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.ViewModel
{
    public class LoginViewModel
    {
        [Required, Display(Name = "UserName")]
        public string? UserName { get; set; }

        [Required, Display(Name = "Password")]
        public string? UserPassword { get; set; }

        [Display(Name = "Remember me ")]
        public bool IsRemember { get; set; }

    }
}
