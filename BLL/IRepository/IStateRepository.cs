using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IStateRepository
    {
        public List<StateModel> states();
        public void CreateState(StateModel state);
        public void UpdateState(StateModel state);
        public void DeleteState(StateModel state);
        public void DetailsState(StateModel state);
        public void SeachById(int id);
    }
}
