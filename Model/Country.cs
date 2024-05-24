using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string CountryName { get; set; }

    }
}
