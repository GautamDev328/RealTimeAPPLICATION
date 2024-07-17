using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTrailController : ControllerBase
    {
        private readonly UserTrailRepository userTrailRepository;
        public UserTrailController(UserTrailRepository _userTrailRepository)
        {
            this.userTrailRepository = _userTrailRepository;
        }
        [HttpDelete("DeleteUsertrail")]
        public UserTrailsModels DeleteUsertrails(int id)
        {
            var delete = userTrailRepository.DeleteUsertrails(id);
            return delete;


        }
        [HttpGet("AllDatUsertrail")]
        public List<UserTrailsModels> GetAll()
        {
            var list = userTrailRepository.GetAll();
            return list;
        }
        [HttpPut("UpdateUsertrail")]
        public IActionResult UpdateUsertrails(UserTrailsModels userTrails)
        {
            userTrailRepository.UpdateUsertrails(userTrails);
            return Ok(1);
        }
        [HttpGet("DetailsUsertrail")]
        public UserTrailsModels DetailsUserstrails(int id)
        {
            var SEARCH = userTrailRepository.DetailsUserstrails(id);
            return SEARCH;
        }
        [HttpPost("CreateUsertrail")]
        public IActionResult InsertUsertrails(UserTrailsModels userTrails)
        {
            userTrailRepository.InsertUsertrails(userTrails);
            return Ok(1);
        }
    }
}