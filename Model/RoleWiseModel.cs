using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class RoleWiseModel
    {
        [Key]
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }
    }
}
