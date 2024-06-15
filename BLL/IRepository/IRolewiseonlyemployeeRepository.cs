using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRolewiseonlyemployeeRepository
    {
        public List<RoleWiseOnlyEmployee> GetAllRoleWiseonlyemployee();
        public void AddRoleWiseonlyemployee(RoleWiseOnlyEmployee rolewiseonlyemployee);
        public void UpdateRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel);
        public void DeleteRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel);
        public void DetailsRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel);
        public void SeachById(int id);


    }

}
