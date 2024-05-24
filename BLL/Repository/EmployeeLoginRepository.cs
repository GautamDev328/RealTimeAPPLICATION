//using CRUDAPPLICATION.BLL.IRepository;
//using CRUDAPPLICATION.DATABASE;
//using CRUDAPPLICATION.Model;

//namespace CRUDAPPLICATION.BLL.Repository
//{
//    public class EmployeeLoginRepository : IEmoloyeeLoginRepository
//    {
//        EmployeeDbContext dbContext;
//        public EmployeeLoginRepository(EmployeeDbContext _DbContext)
//        {
//                this.dbContext = _DbContext;
//        }

//        public void CreaeEmployeeLogin(EmployeeLogin employeeLogin)
//        {
//           dbContext.EmployeeLogins.Add(employeeLogin);
//            dbContext.SaveChanges();
//        }

//        public List<EmployeeLogin> GetALLEmployeeLoginData()
//        {
//            var list=dbContext.EmployeeLogins.ToList();
//            return list;
//        }
//    }
//}
