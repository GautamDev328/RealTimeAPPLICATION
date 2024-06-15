using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IGenderRepository
    {
        public List<Gender> GetGenderAll();
        public void CreateGender(Gender gender);
        public void UpdateGender(Gender gender);
        public void DeleteGender(int id);
        public Gender SearchById(int id);
        public Gender DetailsGender(int id);
    }
}
