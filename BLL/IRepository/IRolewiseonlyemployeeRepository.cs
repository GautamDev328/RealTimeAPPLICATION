using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRolewiseonlyemployeeRepository
    {
        public List<RoleWiseOnlyEmployee> GetAllRoleWiseonlyemployee();
        public void AddRoleWiseonlyemployee(RoleWiseOnlyEmployee rolewiseonlyemployee);
        public void UpdateRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel);
        public void DeleteRoleWiseonlyemployee(int id);
        public RoleWiseOnlyEmployee DetailsRoleWiseonlyemployee(int id);
        public RoleWiseOnlyEmployee SeachById(int id);


    }

}
