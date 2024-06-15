using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class ROLEWISEREPSITORY : IRoleWiseRepository
    {
        EmployeeDbContext _emp;
        public ROLEWISEREPSITORY(EmployeeDbContext emp)
        {
                this._emp = emp;
        }
        public void CreateRoleWiseModel(RoleWiseModel roleWiseModel)
        {
          _emp.roleWise.Add(roleWiseModel);
            _emp.SaveChanges();
        }

        public void DeleteRoleWiseModel(int id)
        {
            var del = _emp.roleWise.Where(s => s.Role_ID == id).FirstOrDefault();
              _emp.roleWise.Remove(del);    
            _emp.SaveChanges();
        }

        public RoleWiseModel DetailsRoleWiseModel(int id)
        {
          var delt=_emp.roleWise.Where(s=>s.Role_ID==id).FirstOrDefault();
            return delt;
        }

        public List<RoleWiseModel> GetRoleWiseRoleAll()
        {
            var list = _emp.roleWise.ToList();
            return list;
        }

        public RoleWiseModel SearchById(int id)
        {
            var search = _emp.roleWise.Where(s => s.Role_ID == id).FirstOrDefault();
            return search;
        }

        public void UpdateRoleWiseModel(RoleWiseModel roleWiseModel)
        {
          _emp.roleWise.Update(roleWiseModel);  
            _emp.SaveChanges();
        }
    }
}
