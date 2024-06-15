using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;
using System.Numerics;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class DesignationRepository:IDesignationRepository
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

        public void DeleteDesignationModel(int   id)
        {
            var delete = EmployeeDb.designations.Where(s => s.DesigId == id).FirstOrDefault();
                           EmployeeDb.designations.Remove(delete);
            EmployeeDb.SaveChanges();

        }

        public DesignationModel DetailsDesignationModel(int  id)
        {
            var details = EmployeeDb.designations.Where(s => s.DesigId == id).FirstOrDefault();
            return details;
        }

        public List<DesignationModel> GetALLDesignationData()
        {
            var list = EmployeeDb.designations.ToList();
            return list;
        }

        public DesignationModel SearchById(int id)
        {
            var search = EmployeeDb.designations.Where(s => s.DesigId == id).FirstOrDefault();
            return search;
        }

        public void UpdateDesignationModel(DesignationModel designationModel)
        {
            EmployeeDb.designations.Update(designationModel);
            EmployeeDb.SaveChanges();

        }
           

        }
    }

