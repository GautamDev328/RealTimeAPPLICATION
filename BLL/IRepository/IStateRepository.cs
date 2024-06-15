using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IStateRepository
    {
        public List<StateModel> states();
        public void CreateState(StateModel state);
        public void UpdateState(StateModel state);
        public void DeleteState(int id);
        public StateModel DetailsState(int id);
        public StateModel SeachById(int id);
    }
}
