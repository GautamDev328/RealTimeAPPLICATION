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

        public void DeleteState(int id)
        {
            var delete = _employeedb.states.Where(s => s.Id == id).FirstOrDefault();
                           _employeedb.states.Remove(delete);   
                            _employeedb.SaveChanges();
        }

        public StateModel DetailsState(int id)
        {
           var details= _employeedb.states.Where(s => s.Id == id).FirstOrDefault();
            return details;
        }

        public StateModel SeachById(int id)
        {

         var search=   _employeedb.states.Where(s => s.Id == id).FirstOrDefault();
            return search;
        }

        public List<StateModel> states()
        {
            var list = _employeedb.states.ToList();
            return list;
        }

        public void UpdateState(StateModel state)
        {
          _employeedb.Update(state);
            _employeedb.SaveChanges();
        }
    }
}
