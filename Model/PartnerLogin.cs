using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
	public class PartnerLogin
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string?  PartnerId { get; set; }
		[Required]
		[StringLength(50)]
		public string UserName { get; set; }
		[Required]
		[Phone]
		public string? MobileNumber { get; set; }
		[Required]
		[EmailAddress]
		public string? EmailAddress { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
