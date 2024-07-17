using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class City
    {

        [Key]
        public int City_Id { get; set; }
        public string City_Name { get; set; }
        public string State_Name { get; set; }
    }
}

