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

        public void DeleteEmployeeQuery(EmployeeQuery employeeQuery)
        {
            throw new NotImplementedException();
        }

        public void DetailsEmployeeQuery(EmployeeQuery employeeQuery)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeQuery> GetEmployeeQueryAll()
        {
            var list = _employeeDbContext.employeeQuery.ToList();
            return list;
        }

        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployeeQuery(EmployeeQuery employeeQuery)
        {
            throw new NotImplementedException();
        }
    }
}
