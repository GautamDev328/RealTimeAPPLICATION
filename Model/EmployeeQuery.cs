using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class EmployeeQuery
    {
        [Key]
        public int Emp_Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeQueryMessage { get; set; }
        public DateTime? GetDateOnly { get; set; }
    }
}
