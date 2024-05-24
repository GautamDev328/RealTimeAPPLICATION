using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRoleWiseRepository
    {
        public List<RoleWiseModel> GetRoleWiseRoleAll();
        public void CreateRoleWiseModel(RoleWiseModel roleWiseModel);
        public void UpdateRoleWiseModel(RoleWiseModel roleWiseModel);
        public void DeleteRoleWiseModel(RoleWiseModel roleWiseModel);
        public void SearchById(int id);
        public void DetailsRoleWiseModel(RoleWiseModel roleWiseModel);
    }
}
