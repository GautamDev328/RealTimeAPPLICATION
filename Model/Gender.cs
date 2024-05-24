using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class Gender
    {
        [Key]
        public int Gen_Id { get; set; }
        public string Gen_Name { get; set; }
    }
}
