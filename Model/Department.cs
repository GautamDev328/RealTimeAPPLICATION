using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class Department
    {
        [Key]
        public int Dep_Id { get; set; }
        public string Dep_Name { get; set; }
        public string Dep_Status { get; set; }
        public string Dep_Type { get; set; }
        public string DesigName { get; set; }
    }
}
