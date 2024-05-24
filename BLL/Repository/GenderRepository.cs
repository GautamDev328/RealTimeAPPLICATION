using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class GenderRepository : IGenderRepository
    {
        EmployeeDbContext employeeDbContext;
        public GenderRepository(EmployeeDbContext _employeeDbContext)
        {
            this.employeeDbContext = _employeeDbContext;
                
        }
        public void CreateGender(Gender gender)
        {
            employeeDbContext.gender.Add(gender);
            employeeDbContext.SaveChanges();
        }

        public void DeleteDepartment(Gender gender)
        {
            throw new NotImplementedException();
        }

        public void DetailsDepartment(Gender gender)
        {
            throw new NotImplementedException();
        }

        public List<Gender> GetGenderAll()
        {
            var list= employeeDbContext.gender.ToList();    
            return list;
        }

        public void SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateGender(Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
