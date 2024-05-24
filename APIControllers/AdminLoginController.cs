//using CRUDAPPLICATION.BLL.Repository;
//using CRUDAPPLICATION.Model;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace CRUDAPPLICATION.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AdminLoginController : ControllerBase
//    {
//        private readonly AdminLoginRepository adminLoginRepository;
//        public AdminLoginController(AdminLoginRepository _adminLoginRepository)
//        {
//            this.adminLoginRepository = _adminLoginRepository;
//        }
//        [HttpPost("CreateAdmin")]
//        public void CreateAdmin(AdminLogin adminLogin)
//        {
//            adminLoginRepository.CreateAdmin(adminLogin);

//        }
//        [HttpGet("ALLDATAAdminLogin")]
//        public List<AdminLogin> GetAllAdminLogin()
//        {
//            var list = adminLoginRepository.GetAllAdminLogin();
//            return list;
//        }
//    }
//}


