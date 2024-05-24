using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class CountryRepository : ICountryRepository
    {
        EmployeeDbContext employeeDbContext;
        public CountryRepository(EmployeeDbContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;

        }
        //public void Create(Country country)
        //{
        //    employeeDbContext.countries.Add(country);
        //    employeeDbContext.SaveChanges();
        //}

        public void CreateCountry(Country country)
        {
            employeeDbContext.countries.Add(country);
            employeeDbContext.SaveChanges();
        }

        public void DeleteCountry(int id)
        {
          var a=  employeeDbContext.countries.Where(s => s.Id == id).FirstOrDefault();
            employeeDbContext.countries.Remove(a);
            employeeDbContext.SaveChanges();

        }

        public Country DetailsCountry(int id)
        {
           var a=employeeDbContext.countries.Where(s=>s.Id == id).FirstOrDefault();
            return a;
         }

        public List<Country> GETCOUNTRYALL()
        {
           var list=employeeDbContext.countries.ToList();
            return list;
        }

        public Country SearChById(int id)
        {
           var a= employeeDbContext.countries.Where(s=>s.Id==id).FirstOrDefault();
            return a;
        }

        public void UpdateCountry(Country country)
        {
           employeeDbContext.countries.Update(country);
            employeeDbContext.SaveChanges();
        }
    }
}
