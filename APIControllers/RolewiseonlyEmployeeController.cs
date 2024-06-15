using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolewiseonlyEmployeeController : ControllerBase
    {
        private readonly RolewiseonlyemployeeRepository rolewise;
        public RolewiseonlyEmployeeController(RolewiseonlyemployeeRepository _rolewise)
        {
            this.rolewise = _rolewise;

        }
        [HttpGet("GetAllRoleWiseOnlyEmployee")]
        public List<RoleWiseOnlyEmployee> GetAllRoleWiseonlyemployee()
        {
            var list = rolewise.GetAllRoleWiseonlyemployee();
            return list;

        }
        [HttpPost("InsertRolseWiseOnlyEmployee")]
      public   void AddRoleWiseonlyemployee(RoleWiseOnlyEmployee rolewiseonlyemployee)
        {
            rolewise.AddRoleWiseonlyemployee(rolewiseonlyemployee);
          
        }
        [HttpPut("UpdateRolseWiseOnlyEmployees")]
        public IActionResult UpdateRoleWiseonlyemployee(RoleWiseOnlyEmployee relationModel)
        {

            rolewise.UpdateRoleWiseonlyemployee((RoleWiseOnlyEmployee)relationModel);
            return Ok(1);
        }
        [HttpDelete("DeleteRolseWiseOnlyEmployees")]
        public IActionResult DeleteRoleWiseonlyemployee(int id)
        {
            rolewise.DeleteRoleWiseonlyemployee(id);
            return Ok(1);
        }
        [HttpGet("SearchRolseWiseOnlyEmployees")]
        public RoleWiseOnlyEmployee Seach(int id)
        {
            var seach=rolewise.SeachById(id);
            return seach;
        }
        [HttpGet("DetaiRoleWiseOnlyEmployees")]
        public RoleWiseOnlyEmployee DetailsRoleWiseonlyemployee(int id)
        {
            var details = rolewise.DetailsRoleWiseonlyemployee(id);
            return details;
        }
    }

}