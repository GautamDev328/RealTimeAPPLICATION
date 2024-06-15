using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRelationRepository
    {
        public List<RelationModel> GetRelationModelAll();
        public void CreateRelaitonModel(RelationModel relationModel);

        public void UpdateRelaitonModel(RelationModel relationModel);
        public void DeleteRelaitonModel(RelationModel relationModel);
        public void DetailsRelaitonModel(RelationModel relationModel);
        public void SeachById(int id);

    }

}
