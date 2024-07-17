using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class RolewiseonlyemployeeRepository : IRolewiseonlyemployeeRepository
    {
        EmployeeDbContext dbcontext;
        public RolewiseonlyemployeeRepository(EmployeeDbContext _dbcontext)
        {
            this.dbcontext = _dbcontext;

        }

        public void AddRoleWiseonlyemployee(RoleWiseOnlyEmployee rolewiseonlyemployee)
        {
            dbcontext.RoleWiseOnlyEmployees.Add(rolewiseonlyemployee);
            dbcontext.SaveChanges();
        }

        public void DeleteRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel)
        {
            throw new NotImplementedException();
        }

        public void DetailsRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel)
        {
            throw new NotImplementedException();
        }

        public List<RoleWiseOnlyEmployee> GetAllRoleWiseonlyemployee()
        {
            var list = dbcontext.RoleWiseOnlyEmployees.ToList();
            return list;
        }

        public void SeachById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel)
        {
            throw new NotImplementedException();
        }
    }
}
