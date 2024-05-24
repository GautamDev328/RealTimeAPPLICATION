using CRUDAPPLICATION.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IEmployeeQueryRepository
    {
        public List<EmployeeQuery> GetEmployeeQueryAll();
        public void CreateEmployeeQuery(EmployeeQuery employeeQuery);
        public void UpdateEmployeeQuery(EmployeeQuery employeeQuery);
        public void DeleteEmployeeQuery(EmployeeQuery employeeQuery);
        public void SearchById(int id);
        public void DetailsEmployeeQuery(EmployeeQuery employeeQuery);
    }
}
