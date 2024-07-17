using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
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
            this._genderRepository = genderRepository;
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
    }
}
