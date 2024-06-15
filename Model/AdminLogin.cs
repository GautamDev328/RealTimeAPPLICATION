using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class AdminLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public string Email { get; set; }
    }
}
