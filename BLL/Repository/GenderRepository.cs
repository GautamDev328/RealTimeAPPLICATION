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

        public void DeleteGender(int id)
        {
            var del = employeeDbContext.gender.Where(s => s.Gen_Id == id).FirstOrDefault();
            employeeDbContext.gender.Remove(del);
            employeeDbContext.SaveChanges();
        }

        public Gender DetailsGender(int id)
        {
           var delt = employeeDbContext.gender.Where(s => s.Gen_Id == id).FirstOrDefault();
            return delt;
        }

        public List<Gender> GetGenderAll()
        {
            var list = employeeDbContext.gender.ToList();
            return list;
        }

        public Gender SearchById(int id)
        {
            var search = employeeDbContext.gender.Where(s => s.Gen_Id == id).FirstOrDefault();
            return search;
        }

        public void UpdateGender(Gender gender)
        {
            employeeDbContext.gender.Update(gender);
            employeeDbContext.SaveChanges();
        }
    }
}
