using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface IRelationRepository
    {
        public List<RelationModel> GetRelationModelAll();
        public void CreateRelaitonModel(RelationModel relationModel);

        public void UpdateRelaitonModel(RelationModel relationModel);
        public void DeleteRelaitonModel(int  id);
        public RelationModel DetailsRelaitonModel(int id);
        public RelationModel SeachById(int id);

    }

}
