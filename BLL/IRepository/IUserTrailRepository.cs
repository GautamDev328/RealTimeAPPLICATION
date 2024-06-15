using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IUserTrailRepository
    {
        public List<UserTrail> usersalldata();
        public  void CreateUserTrail(UserTrail userTrail);
        public void UpdateUserTrail(UserTrail userTrail);
        public void DeleteUserTrail(int id);
        public UserTrail SearchUser(int id);
       
    }
}
