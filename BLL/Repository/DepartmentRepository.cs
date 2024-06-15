using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
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
           employeeDbContext.department.Update(department);
            employeeDbContext.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var delete = employeeDbContext.department.Where(s => s.Dep_Id == id).FirstOrDefault();// Linque 
             employeeDbContext.department.Remove(delete);
             employeeDbContext.SaveChanges();
        }

        public Department SearchById(int id)
        {
            var a= employeeDbContext.department.Where(s=>s.Dep_Id==id).FirstOrDefault();
            return a;
        }

        public Department DetailsDepartments(int id)
        {
              var a=employeeDbContext.department.Where(s => s.Dep_Id == id).FirstOrDefault();
            return a;
        }

     
    }
}
