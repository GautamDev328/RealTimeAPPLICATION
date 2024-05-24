using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class CustomerPrice
    {
        [Key]
        public int Id { get; set; }
        public string CustomerExtraPrice { get; set; }
        public string CustomerExtraUser { get; set; }
    }
}
