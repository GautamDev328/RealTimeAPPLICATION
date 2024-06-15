using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTrailController : ControllerBase
    {
        private readonly UserTrailRepositroy userTrailRepositroy;
        public UserTrailController(UserTrailRepositroy _userTrailRepositroy)
        {
            this.userTrailRepositroy = _userTrailRepositroy;
        }
        [HttpGet("AllDataUserTrail")]
        public List<UserTrail> usersalldata()
        {
            var list = userTrailRepositroy.usersalldata();
            return list;
        }
        [HttpPost("CreateUserTrail")]
        public IActionResult CreateUserTrail(UserTrail userTrail) { 
        
             userTrailRepositroy.CreateUserTrail(userTrail);
            return Ok(1);
           
        }
        [HttpPut("UpdateUserTrail")]
        public IActionResult UpdateUserTrail(UserTrail userTrail)
        {
            userTrailRepositroy.UpdateUserTrail(userTrail);
            return Ok(1);

        }
        [HttpDelete("DeleteUserTrail")]
        public IActionResult DeleteUserTrail(int id)
        {
            userTrailRepositroy.DeleteUserTrail(id);
            return Ok(1);
        }

        [HttpGet("SearchUserTrail")]
        public IActionResult SearchUserTrail(int id) {
         var a=   userTrailRepositroy.SearchUser(id);
                return Ok(a);
           
        }
    } 
}