using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class UserTrailRepositroy : IUserTrailRepository
    {

        EmployeeDbContext context;
        public UserTrailRepositroy(EmployeeDbContext dbContext)
        {
            this.context = dbContext;

        }

        public List<UserTrail> usersalldata()
        {
            var list = context.usertrails.ToList();
            return list;
        }
        public void CreateUserTrail(UserTrail userTrail)
        {
            context.usertrails.Add(userTrail);
            context.SaveChanges();
        }

        public void UpdateUserTrail(UserTrail userTrail)
        {
            context.usertrails.Update(userTrail);
            context.SaveChanges();
        }

        public void DeleteUserTrail(int id)
        {
            var delete = context.usertrails.Where(s => s.Id == id).FirstOrDefault();
            context.usertrails.Remove(delete);

            context.SaveChanges();
        }

        public UserTrail SearchUser(int id)
        {
            var search = context.usertrails.Where(s => s.Id == id).FirstOrDefault();
            return search;
        }
    }
}
