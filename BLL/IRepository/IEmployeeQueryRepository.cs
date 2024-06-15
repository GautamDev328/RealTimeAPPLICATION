using CRUDAPPLICATION.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IEmployeeQueryRepository
    {
        public List<EmployeeQuery> GetEmployeeQueryAll();
        public void CreateEmployeeQuery(EmployeeQuery employeeQuery);
        public void UpdateEmployeeQuery(EmployeeQuery employeeQuery);
        public void DeleteEmployeeQuery(int  id);
        public EmployeeQuery SearchById(int id);
        public EmployeeQuery DetailsEmployeeQuery(int id);
    }
}
