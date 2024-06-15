using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class UserTrail
    {
  
            [Key]
            public int Id { get; set; }

            [Required]
            public int CompanyId { get; set; }

            [Required]
            [StringLength(100)]
            public string? CompanyName { get; set; }

            [Required]
            [StringLength(200)]
            public string? CompanyAddress { get; set; }

            [Required]
            [EmailAddress]
            public string? EmailAddress { get; set; }

            [Required]
            [Phone]
            public string? PhoneNumber { get; set; }

            [Required]
            [StringLength(50)]
            public string? CorporateId { get; set; }

            [Required]
            [StringLength(50)]
            public string? UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string? Password { get; set; }

            [Required]
            [Compare("Password")]
            [DataType(DataType.Password)]
            public string? ConfirmPassword { get; set; }

            [Required]
            //[RegularExpression(@"^[A-Z]\d{2}0\d$", ErrorMessage = "PartnerId must start with one uppercase letter, followed by two digits, a zero, and a numeric digit, making a total of 5 characters.")]
            public string? PartnerId { get; set; }

            [StringLength(100)]
            public string? DealerName { get; set; }

            [Url]
            public string? PhotoUrl { get; set; }

            [StringLength(100)]
            public string? PhotoDrop { get; set; }
        }
    }


