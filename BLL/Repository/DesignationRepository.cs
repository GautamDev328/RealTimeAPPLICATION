using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class DesignationRepository : IDesignationRepository
    {
        EmployeeDbContext EmployeeDb;
        public DesignationRepository(EmployeeDbContext _employeeDb)
        {
            this.EmployeeDb = _employeeDb;

        }


        public void CreateDesignation(DesignationModel designationModel)
        {
            EmployeeDb.designations.Add(designationModel);
            EmployeeDb.SaveChanges();
        }

        public void DeleteDesignationModel(DesignationModel designationModel)
        {
            throw new NotImplementedException();
        }

        public void DetailsDesignationModel(DesignationModel designationModel)
        {
            throw new NotImplementedException();
        }

        public List<DesignationModel> GetALLDesignationData()
        {
            var list = EmployeeDb.designations.ToList();
            return list;
        }

        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDesignationModel(DesignationModel designationModel)
        {
            throw new NotImplementedException();
        }
    }
}
