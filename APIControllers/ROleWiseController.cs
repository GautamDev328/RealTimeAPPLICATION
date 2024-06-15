using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ROleWiseController : ControllerBase
    {
        private readonly ROLEWISEREPSITORY _Irolewoserepsoitory;
        public ROleWiseController(ROLEWISEREPSITORY roleWiseRepository)
        {
              this._Irolewoserepsoitory=roleWiseRepository;
        }
        [HttpPost("CreateRoleWiseModel")]
        public void CreateRoleWiseModel(RoleWiseModel roleWiseModel)
        {
            _Irolewoserepsoitory.CreateRoleWiseModel(roleWiseModel);

        }
        [HttpGet("ALLDATARoleWiseModel")]
        public List<RoleWiseModel> GetRoleWiseRoleAll()
        {
            var list = _Irolewoserepsoitory.GetRoleWiseRoleAll();
            return list;
        }
        [HttpPut("UpdateRoleWise")]
        public IActionResult UpdateRoleWiseModel(RoleWiseModel roleWiseModel)
        {
            _Irolewoserepsoitory.UpdateRoleWiseModel(roleWiseModel);
            return Ok(1);
        }
        [HttpDelete("DeleteRoleWise")]
        public IActionResult DeleteRoleWiseModel(int id)
        {
            _Irolewoserepsoitory.DeleteRoleWiseModel(id);
            return Ok(1);
        }
        [HttpGet("SearchRolseWise")]
        public RoleWiseModel SearchRole(int id)
        {
            var searchrole=_Irolewoserepsoitory.SearchById(id);
            return searchrole;
        }
        [HttpGet("DetaiRolseWise")]
        public RoleWiseModel DetailsRoleWise(int id)
        {
            var deltailrolsewise = _Irolewoserepsoitory.DetailsRoleWiseModel(id);
            return deltailrolsewise;
        }
    }
}
