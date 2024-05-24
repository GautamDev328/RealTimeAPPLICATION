using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class RoleWiseOnlyEmployee
    {
        [Key]
        public  int RoleWiseonlyId {get;  set;}
        public string? RoleWiseonlyName {get; set;}
        public string? Role_Name {get;  set;}
    }
}
