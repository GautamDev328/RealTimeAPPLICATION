using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly GenderRepository _genderRepository;
        public GenderController(GenderRepository genderRepository)
        {
                this._genderRepository= genderRepository;
        }
        [HttpPost("CreateGender")]
        public void CreateGender(Gender gender)
        {
            _genderRepository.CreateGender(gender);

        }
        [HttpGet("ALLDATAGender")]
        public List<Gender> GetGenderAll()
        {
            var list = _genderRepository.GetGenderAll();
            return list;
        }
        [HttpPut("UpdateGender")]
        public IActionResult UpdateGender(Gender gender)
        {
            _genderRepository.UpdateGender(gender);
            return Ok(1);
        }
        [HttpDelete("DeleteGender")]
        public IActionResult DeleteGender(int id)
        {
            _genderRepository.DeleteGender(id);
            return Ok(1);
        }
        [HttpGet("SearchGender")]
        public Gender Search(int id)
        {
            var search= _genderRepository.SearchById(id);   
            return search;
        }

        [HttpGet("DetailsGender")]
        public Gender DetailGender(int id)
        {
            var details = _genderRepository.SearchById(id);
            return details;
        }

    }
}
