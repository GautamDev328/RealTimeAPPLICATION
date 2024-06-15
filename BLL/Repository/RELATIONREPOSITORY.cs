using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class RELATIONREPOSITORY : IRelationRepository
    {
        EmployeeDbContext _EMP;
        public RELATIONREPOSITORY(EmployeeDbContext employee)
        {
                this._EMP = employee;
        }
        public void CreateRelaitonModel(RelationModel relationModel)
        {
            _EMP.relationModels.Add(relationModel);
            _EMP.SaveChanges();
        }

        public void DeleteRelaitonModel(RelationModel relationModel)
        {
            throw new NotImplementedException();
        }

        public void DetailsRelaitonModel(RelationModel relationModel)
        {
            throw new NotImplementedException();
        }

        public List<RelationModel> GetRelationModelAll()
        {
            var list = _EMP.relationModels.ToList();
            return list;    
        }

        public void SeachById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRelaitonModel(RelationModel relationModel)
        {
            throw new NotImplementedException();
        }
    }
}
