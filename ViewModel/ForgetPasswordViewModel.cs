using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.ViewModel
{
    public class ForgetPasswordViewModel
    {
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        [Required(ErrorMessage = "Please enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("AdminPassword")]
        public string ConfirmPassword { get; set; }
    }
}
