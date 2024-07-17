using System.ComponentModel.DataAnnotations;

namespace CRUDAPPLICATION.Model
{
    public class RelationModel
    {
        [Key]
        public int Relat_Id { get; set; }
        public string Relation_Name { get; set; }
        public string MobileNumber { get; set; }

    }
}
