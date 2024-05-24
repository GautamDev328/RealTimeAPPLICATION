using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CityRepository cityRepository;
        public CityController(CityRepository _cityRepository)
        {
            this.cityRepository = _cityRepository;
                
        }
        [HttpPost("CREATECITY")]
        public IActionResult CreateCity(City city)
        {
            cityRepository.CreateCity(city);
            return Ok(1);
            

        }
        [HttpGet("ALLDATACITY")]
        public List<City> GetCities()
        {
            var list=cityRepository.GetCities();
            return list;
         }

        [HttpPost("UpdateCity")]
     public IActionResult UpdateCity(City city)
        {
        cityRepository.UpdateCity(city);
            return Ok(1);
        }
        [HttpGet("SearchById")]
        public IActionResult SearchById(int id)
        {
          var a=  cityRepository.SearchById(id);
            return Ok(a);
        }
        [HttpGet("DetailsCity")]
        public IActionResult DetailCity(int id)
        {
         var a= cityRepository.DetailCity(id);
            return Ok(a) ;
        }
        [HttpDelete("DeleteCity")]
        public IActionResult DeleteCity(int id)
        {
            cityRepository.DeleteCity(id);
            return Ok(1);
        }
    }
}
