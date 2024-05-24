using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryRepository countryRepository;
        public CountryController(CountryRepository _countryRepository)
        {
            this.countryRepository = _countryRepository;
                
        }
        [HttpPost("CreateCountry")]
        public void CreateCountry(Country country)
        {
            countryRepository.CreateCountry(country);
            
        }
        [HttpGet("GETCOUNTRYALL")]
     public    List<Country> GETCOUNTRYALL()
        {
           var list=  countryRepository.GETCOUNTRYALL();
            return list;
        }
        [HttpPut("UpdateCountry")]
        public IActionResult UpdateCountry(Country country)
        {
            countryRepository.UpdateCountry(country);
            return Ok(1);

        }
        [HttpDelete("DeleteCountry")]
        public IActionResult DeleteCountry(int id)
        {
            countryRepository.DeleteCountry(id);
            return Ok(1);

        }
        [HttpGet("DetailsCountry")]
        public Country DetailsCountry(int id)
        {
            var a = countryRepository.DetailsCountry(id);
            return a;

        }



    }
}
