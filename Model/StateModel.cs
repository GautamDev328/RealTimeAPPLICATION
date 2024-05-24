using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class StateModel
    {
        [Key]
        public int Id { get; set; }
        public string StateId { get; set; }

        public string StateName { get; set; }
    }
}
