using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRoleWiseRepository
    {
        public List<RoleWiseModel> GetRoleWiseRoleAll();
        public void CreateRoleWiseModel(RoleWiseModel roleWiseModel);
        public void UpdateRoleWiseModel(RoleWiseModel roleWiseModel);
        public void DeleteRoleWiseModel(int  id );
        public RoleWiseModel SearchById(int id);
        public RoleWiseModel DetailsRoleWiseModel(int  id);
    }
}
