using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        EmployeeDbContext _employeeDbContext;
        public EmployeeQueryRepository(EmployeeDbContext employeeDbContext)
        {
               
            this._employeeDbContext = employeeDbContext;
        }
        public void CreateEmployeeQuery(EmployeeQuery employeeQuery)
        {
          _employeeDbContext.employeeQuery.Add(employeeQuery);
            _employeeDbContext.SaveChanges();
        }

        public void DeleteEmployeeQuery(int id)
        {
            var del = _employeeDbContext.employeeQuery.Where(s => s.Emp_Id == id).FirstOrDefault();
                       _employeeDbContext.Remove(del);
                     _employeeDbContext.SaveChanges();
        }

        public EmployeeQuery DetailsEmployeeQuery(int id)
        {

            var delt = _employeeDbContext.employeeQuery.Where(s => s.Emp_Id == id).FirstOrDefault();
            return delt;
        }

        public List<EmployeeQuery> GetEmployeeQueryAll()
        {
            var list = _employeeDbContext.employeeQuery.ToList();
            return list;
        }

        public EmployeeQuery SearchById(int id)
        {
            var search = _employeeDbContext.employeeQuery.Where(s => s.Emp_Id == id).FirstOrDefault();
            return search;
        }

        public void UpdateEmployeeQuery(EmployeeQuery employeeQuery)
        {
           _employeeDbContext.employeeQuery.Update(employeeQuery);  
            _employeeDbContext.SaveChanges();
        }
    }
}
