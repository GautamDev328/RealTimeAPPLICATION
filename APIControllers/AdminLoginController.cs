using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.DTOModel;
using CRUDAPPLICATION.Migrations;
using CRUDAPPLICATION.Model;
using CRUDAPPLICATION.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        private readonly AdminLoginRepository adminLoginRepository;
        public AdminLoginController(AdminLoginRepository _adminLoginRepository)
        {
            this.adminLoginRepository = _adminLoginRepository;
        }
        [HttpGet("GetAdminAll")]
        public IActionResult AdminList()
        {
            return Ok(adminLoginRepository.GetAdminAll());
        }
        [HttpPost("CreateAdmin")]
        public IActionResult CreateAdmin(ADMINDTO admindto)
        {
            AdminLogin objmodel = new AdminLogin()
            {
             UserName  = admindto.UserName,
             UserPassword = admindto.UserPassword,
                Email = admindto.Email
            };

       adminLoginRepository.AddLoginUser(objmodel);
            return Ok(1);
        }

           
        

        [HttpPut("UpdateAdmin")]
        public IActionResult UpdateAdmin(ADMINDTO userDto)
        {
            AdminLogin objmodel = new AdminLogin()
            {
                UserName = userDto.UserName,
                UserPassword = userDto.UserPassword,
                Email = userDto.Email
            };

            adminLoginRepository.Updateadmin(objmodel);
            return Ok(1);
        }
        [HttpGet("SearchAdmin")]
        public IActionResult SearchUser(string userName)
        {

          ADMINDTO aDMINDTO = new ADMINDTO();
            AdminLogin adminLogin = adminLoginRepository.SearchByadmin(userName);
            aDMINDTO.UserName = adminLogin.UserName;
            aDMINDTO.UserPassword= adminLogin.UserPassword;
            aDMINDTO.Email = adminLogin.Email;

            return Ok(aDMINDTO);
           
        }
        [HttpDelete("DeleteAdmin")]
        public IActionResult Deleteadmin(int  id)
        {
           adminLoginRepository.Deleteadmin(id);
            return Ok(1);
           
        }
        [HttpPost("LoginAdmin")]
        public IActionResult LoginUser(AdminLogin user)
        {
            return Ok(adminLoginRepository.ValidateAccount(user.UserName, user.UserPassword));
        }
    }
}


