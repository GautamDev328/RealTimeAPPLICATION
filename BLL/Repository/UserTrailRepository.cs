using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class UserTrailRepository : IUserTrailRepository
    {
        private EmployeeDbContext _employeeDbContext;
        public UserTrailRepository(EmployeeDbContext employeeDbContext)
        {
            this._employeeDbContext = employeeDbContext;
        }

        public UserTrailsModels DeleteUsertrails(int id)
        {
            var delete = _employeeDbContext.userTrails.Where(s => s.UsertrailId == id).FirstOrDefault();
            _employeeDbContext.userTrails.Remove(delete);
            return delete;
        }

        public UserTrailsModels DetailsUserstrails(int id)
        {
            var SEARCH = _employeeDbContext.userTrails.Where(s => s.UsertrailId == id).FirstOrDefault();
            return SEARCH;
        }

        public List<UserTrailsModels> GetAll()
        {
            var list = _employeeDbContext.userTrails.ToList();
            return list;
        }

        public void InsertUsertrails(UserTrailsModels userTrails)
        {
            _employeeDbContext.userTrails.Add(userTrails);
            _employeeDbContext.SaveChanges();

        }

        public void UpdateUsertrails(UserTrailsModels userTrails)
        {
            _employeeDbContext.userTrails.Update(userTrails);
            _employeeDbContext.SaveChanges();
        }
    }
}
