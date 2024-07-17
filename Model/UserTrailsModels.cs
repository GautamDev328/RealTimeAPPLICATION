using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class UserTrailsModels
    {
        [Key]
        public int UsertrailId { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CorporateId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Confrompassword { get; set; }
        public string PartnerId { get; set; }
        public string DealerName { get; set; }
        public string photodrop { get; set; }


    }
}
