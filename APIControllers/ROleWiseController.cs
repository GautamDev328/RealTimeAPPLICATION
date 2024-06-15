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
    }
}
