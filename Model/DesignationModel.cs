using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class DesignationModel
    {
        [Key]
        public int DesigId { get; set; }
        public string DesigName { get; set; }
        public string DesigDescription { get; set; }
        public string DesigType { get; set; }



    }
}
