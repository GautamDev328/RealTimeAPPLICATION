

//using CRUDAPPLICATION.BLL.IRepository;
//using CRUDAPPLICATION.DATABASE;
//using CRUDAPPLICATION.Model;

//namespace CRUDAPPLICATION.BLL.Repository
//{
//    public class AdminLoginRepository : IAdminLoginRepository
//    {
//        EmployeeDbContext dbContext;
//        public AdminLoginRepository(EmployeeDbContext _dbContext)
//        {
//                this.dbContext = _dbContext;
//        }

//        public void CreateAdmin(AdminLogin adminLogin)
//        {
//            dbContext.adminlogin.Add(adminLogin);
//            dbContext.SaveChanges();
//        }

    
//        public List<AdminLogin> GetAllAdminLogin()
//        {
//            var list = dbContext.adminlogin.ToList();
//            return list;
//        }

    
//    }
//}
