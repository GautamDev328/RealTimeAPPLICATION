using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class EmployeeProfile
    {
        [Key]
        public int id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }    
        public  string  Mobile { get; set; }
        public string Gender { get; set; }
        public  DateTime? DateTime { get; set; } 
        public int Age { get; set; }
    }
}
