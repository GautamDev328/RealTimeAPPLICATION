using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
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
        public void AddRoleWiseonlyemployee(RoleWiseOnlyEmployee rolewiseonlyemployee)
        {
            rolewise.AddRoleWiseonlyemployee(rolewiseonlyemployee);

        }
    }

}