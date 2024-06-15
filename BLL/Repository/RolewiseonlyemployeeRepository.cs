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

        public void DeleteRoleWiseonlyemployee(int id)
        {
            var delete = dbcontext.RoleWiseOnlyEmployees.Where(s => s.RoleWiseonlyId == id).FirstOrDefault();
                  dbcontext.RoleWiseOnlyEmployees.Remove(delete);
                dbcontext.SaveChanges();
        }

        public RoleWiseOnlyEmployee DetailsRoleWiseonlyemployee(int id)
        {
           var details= dbcontext.RoleWiseOnlyEmployees.Where(s=>s.RoleWiseonlyId==id).FirstOrDefault();
            return details;

        }

        public List<RoleWiseOnlyEmployee> GetAllRoleWiseonlyemployee()
        {
            var list = dbcontext.RoleWiseOnlyEmployees.ToList();
            return list;
        }

        public RoleWiseOnlyEmployee SeachById(int id)
        {
            var search = dbcontext.RoleWiseOnlyEmployees.Where(s => s.RoleWiseonlyId == id).FirstOrDefault();
            return search;
        }

        public void UpdateRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel)
        {
          dbcontext.RoleWiseOnlyEmployees.Update(relationModel);
            dbcontext.SaveChanges();
        }
    }
}
