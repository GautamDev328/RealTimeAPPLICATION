using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class StateRepository : IStateRepository
    {
        EmployeeDbContext _employeedb;
        public StateRepository(EmployeeDbContext employeeDb)
        {
           this. _employeedb = employeeDb;

        }
        public void CreateState(StateModel state)
        {
            _employeedb.states.Add(state);
            _employeedb.SaveChanges();

        }

        public void DeleteState(StateModel state)
        {
            throw new NotImplementedException();
        }

        public void DetailsState(StateModel state)
        {
            throw new NotImplementedException();
        }

        public void SeachById(int id)
        {
            throw new NotImplementedException();
        }

        public List<StateModel> states()
        {
            var list = _employeedb.states.ToList();
            return list;
        }

        public void UpdateState(StateModel state)
        {
            throw new NotImplementedException();
        }
    }
}
