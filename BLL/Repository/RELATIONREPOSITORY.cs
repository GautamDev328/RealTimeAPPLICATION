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

        public void DeleteRelaitonModel(int id)
        {
            var del = _EMP.relationModels.Where(s => s.Relat_Id == id).FirstOrDefault();
                          _EMP.relationModels.Remove(del);
                      _EMP.SaveChanges();
        }

        public RelationModel DetailsRelaitonModel(int id)
        {
            var delt=_EMP.relationModels.Where(s=>s.Relat_Id==id).FirstOrDefault();
            return delt;
        }

        public List<RelationModel> GetRelationModelAll()
        {
            var list = _EMP.relationModels.ToList();
            return list;
        }

        public RelationModel SeachById(int id)
        {
            var search = _EMP.relationModels.Where(s => s.Relat_Id==id).FirstOrDefault();
            return search; 
        }

        public void UpdateRelaitonModel(RelationModel relationModel)
        {
           _EMP.relationModels.Update(relationModel);   
            _EMP.SaveChanges();
        }
    }
}