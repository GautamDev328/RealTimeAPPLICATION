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

        public void DeleteRoleWiseModel(RoleWiseModel roleWiseModel)
        {
            throw new NotImplementedException();
        }

        public void DetailsRoleWiseModel(RoleWiseModel roleWiseModel)
        {
            throw new NotImplementedException();
        }

        public List<RoleWiseModel> GetRoleWiseRoleAll()
        {
            var list = _emp.roleWise.ToList();
            return list;
        }

        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoleWiseModel(RoleWiseModel roleWiseModel)
        {
            throw new NotImplementedException();
        }
    }
}
