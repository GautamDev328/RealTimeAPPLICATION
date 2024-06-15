using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAllDepartmentData();
        public void CreateDepartment(Department department);
        public void UpdateDepartment(Department department);
        public void DeleteDepartment(int  id);
        public Department SearchById(int id);
        public Department DetailsDepartments(int id);
    }
}
