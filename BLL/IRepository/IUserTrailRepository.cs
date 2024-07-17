using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IUserTrailRepository
    {
        public List<UserTrailsModels> GetAll();
        public void InsertUsertrails(UserTrailsModels userTrails);
        public void UpdateUsertrails(UserTrailsModels userTrails);
        public UserTrailsModels DeleteUsertrails(int id);
        public UserTrailsModels DetailsUserstrails(int id);
    }
}
