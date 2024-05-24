using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface ICountryRepository
    {
        public List<Country> GETCOUNTRYALL();
        public void CreateCountry(Country country);
        public void UpdateCountry(Country country);
        public void DeleteCountry(int id );
        public Country DetailsCountry(int id );
        public Country SearChById(int id);
    }

}
