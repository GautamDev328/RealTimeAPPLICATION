using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class CityRepository : ICityRepository
    {
        EmployeeDbContext _EmployeeDbContext;
        public CityRepository(EmployeeDbContext EmployeeDbContext)

        {
           this. _EmployeeDbContext = EmployeeDbContext;

        }

        public void CreateCity(City city)
        {
            _EmployeeDbContext.citys.Add(city);
            _EmployeeDbContext.SaveChanges();
        }

        public void DeleteCity(int id)
        {
          var a=  _EmployeeDbContext.citys.Where(s => s.City_Id == id).FirstOrDefault();
                  _EmployeeDbContext.citys.Remove(a);
                 _EmployeeDbContext.SaveChanges();


        }

        //public void DetailsCity(int id )
        //{
        //    _EmployeeDbContext.citys.Where(s => s.City_Id == id).FirstOrDefault();
        //    _EmployeeDbContext.SaveChanges();
        //}

        public List<City> GetCities()
        {
            var list = _EmployeeDbContext.citys.ToList();
            return list;
        }

       

        public void  UpdateCity(City city)
        {
          _EmployeeDbContext.citys.Update(city);
             _EmployeeDbContext.SaveChanges();
         

        }



        public City DetailCity(int id)
        {
            var a = _EmployeeDbContext.citys.Where(s => s.City_Id == id).FirstOrDefault();
            return a;
        }

        public City SearchById(int id)
        {
            var b= _EmployeeDbContext.citys.Where(s => s.City_Id == id).FirstOrDefault();
            return b;
        }
    }
}
