//using CRUDAPPLICATION.BLL.IRepository;
//using CRUDAPPLICATION.DATABASE;
//using CRUDAPPLICATION.Model;

//namespace CRUDAPPLICATION.BLL.Repository
//{
//    public class HRLOGINRESPOROTY : IHRLoginRepository
//    {
//        EmployeeDbContext _emp;
//        public HRLOGINRESPOROTY(EmployeeDbContext emp)
//        {
//                this._emp = emp;
//        }
//        public void CreateHRLogin(HRLOGIN hRLOGIN)
//        {
//           _emp.hrlogin.Add(hRLOGIN);
//            _emp.SaveChanges();
//        }

//        public List<HRLOGIN> GetHrLoginAll()
//        {
//            var list= _emp.hrlogin.ToList();
//            return list;
//        }
//    }
//}
