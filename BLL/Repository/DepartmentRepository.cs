using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        EmployeeDbContext employeeDbContext;
        public DepartmentRepository(EmployeeDbContext _employeeDbContext)
        {
            this.employeeDbContext = _employeeDbContext;
                
        }
       

        public List<Department> GetAllDepartmentData()
        {
           var list=employeeDbContext.department.ToList();
            return list;
        }

        public void CreateDepartment(Department department)
        {
           employeeDbContext.department.Add(department);    
            employeeDbContext.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public void DetailsDepartments(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
