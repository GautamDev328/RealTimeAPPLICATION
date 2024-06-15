using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IGenderRepository
    {
        public List<Gender> GetGenderAll();
        public void CreateGender(Gender gender);
        public void UpdateGender(Gender gender);
        public void DeleteDepartment(Gender gender);
        public void SearchById(int id);
        public void DetailsDepartment(Gender gender);
    }
}
