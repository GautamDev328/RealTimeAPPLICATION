using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class EmployeeProfile
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Enter the FirstName")]
        public string FirstName { get; set; }
        [DisplayName("Enter the LastName")]

        public string? LastName { get; set; } = " ";

        [DisplayName("Enter the Designation")]
        [Required]

        public string Designation { get; set; }

        [DisplayName("Enter the Address")]
        [Required]

        public string Address { get; set; }
        [DisplayName("Enter the City")]

        public string? City { get; set; } = " ";
        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be exactly 10 digits")]
        [DisplayName("Enter the Mobile Number")]

        public string Mobile { get; set; }
        //[DisplayName("Enter the Mobile Number")]
        //[RegularExpression("^[0-9]{10}$", ErrorMessage = "Mobile number must be exactly 10 digits")]
        //[Required(ErrorMessage = "Mobile number is required")]


        //   public string Mobile { get; set; }
        [DisplayName("Enter the Gender")]
        [Required]


        public string Gender { get; set; }
        [DisplayName("Enter the DateOfBirth")]
        [Required]


        public DateTime? DateOfBirth { get; set; }
        [DisplayName("Enter the Age")]
        [Required]

        public int Age { get; set; }
    }
}
