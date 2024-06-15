using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAllDepartmentData();
        public void CreateDepartment(Department department);
        public void UpdateDepartment(Department department);
        public void DeleteDepartment(Department department);
        public void SearchById(int id);
        public void DetailsDepartments(Department department);
    }
}
