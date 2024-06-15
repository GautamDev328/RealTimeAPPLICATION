

using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.DTOModel;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class AdminLoginRepository : IAdminLoginRepository
    {
        EmployeeDbContext dbContext;
        public AdminLoginRepository(EmployeeDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public void AddLoginUser(AdminLogin admin)
        {
            dbContext.adminlogin.Add(admin);
            dbContext.SaveChanges();
           
        }

        public void Deleteadmin(int id)
        {
            var delete = dbContext.adminlogin.Where(s => s.Id == id).FirstOrDefault();
            dbContext.adminlogin.Remove(delete);
            dbContext.SaveChanges();


        }

        public List<AdminLogin> GetAdminAll()
        {
            var list = dbContext.adminlogin.ToList();
            return list;
        }

        public AdminLogin SearchByadmin(string userName)
        {
            var search = dbContext.adminlogin.Where(s => s.UserName ==userName).SingleOrDefault();
            return search;


        }

        public void Updateadmin(AdminLogin admin)
        {
              dbContext.adminlogin.Update(admin);
            dbContext.SaveChanges();
        }

        public bool ValidateAccount(string AdminName, string password)
        {
            var temp = dbContext.adminlogin.Where(e => e.UserName == AdminName && e.UserPassword == password).ToList();
            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
