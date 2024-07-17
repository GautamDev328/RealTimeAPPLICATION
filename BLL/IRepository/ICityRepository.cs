using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface ICityRepository
    {
        public List<City> GetCities();
        public void CreateCity(City city);
        public void UpdateCity(City city);
        public void DeleteCity(int id);
        //public EmployeeProfile Search(int id);
        public City DetailCity(int id);
        public City SearchById(int id);

    }
}
