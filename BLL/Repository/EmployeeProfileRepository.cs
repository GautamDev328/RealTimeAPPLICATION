//using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class EmployeeProfileRepository : IEmployeeProfileRepository
    {
        EmployeeDbContext employeeDbContext;
        public EmployeeProfileRepository(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }

      

        public EmployeeProfile delete(int id)
        {
            var employee = employeeDbContext.employeeProfiles.FirstOrDefault(a => a.id == id);

            if (employee != null)
            {
                employeeDbContext.employeeProfiles.Remove(employee);
                employeeDbContext.SaveChanges();
            }

            return employee;
        }

        public List<EmployeeProfile> GetAll()
        {
            var a = employeeDbContext.employeeProfiles.ToList();
            employeeDbContext.SaveChanges();
            return a;
        }

        public void insert(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.Add(employeeProfile);
            employeeDbContext.SaveChanges();



        }



    
        public void update(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.Update(employeeProfile);
            employeeDbContext.SaveChanges();
        }



        public EmployeeProfile Search(int id)
        {
            var a = employeeDbContext.employeeProfiles.Where(s => s.id == id).FirstOrDefault();
            return a;
        }

        public void updateEmployeeProfile(EmployeeProfile employeeProfile)
        {
            employeeDbContext.employeeProfiles.Update(employeeProfile);
            employeeDbContext.SaveChanges();
        }

     

      
        public void deleteEmployeeProfile(int id)
        {
           var delete= employeeDbContext.employeeProfiles.Where(s=>s.id==id).FirstOrDefault();
            employeeDbContext.employeeProfiles.Remove(delete);
            employeeDbContext.SaveChanges();
        }

        public EmployeeProfile DetailsEmployeeProfile(int id)
        {
            var b = employeeDbContext.employeeProfiles.Where(s => s.id == id).FirstOrDefault();
            return b;
        }
    }
}