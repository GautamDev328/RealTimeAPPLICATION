//using CRUDAPPLICATION.BLL.Repository;
//using CRUDAPPLICATION.Model;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Runtime.CompilerServices;

//namespace CRUDAPPLICATION.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmployeeLoginController : ControllerBase
//    {
//        private readonly EmployeeLoginRepository emoloyeeLoginRepository;
//        public EmployeeLoginController(EmployeeLoginRepository _emoloyeeLoginRepository)
//        {
//                this.emoloyeeLoginRepository = _emoloyeeLoginRepository;
//        }
//        [HttpPost("CreaeEmployeeLogin")]
//        public void CreaeEmployeeLogin(EmployeeLogin employeeLogin)
//        {
//            emoloyeeLoginRepository.CreaeEmployeeLogin(employeeLogin);

//        }
//        [HttpGet("ALLDATAEmployeeLogin")]
//        public List<EmployeeLogin> GetALLEmployeeLoginData()
//        {
//            var list = emoloyeeLoginRepository.GetALLEmployeeLoginData();
//            return list;
//        }
//    }
//}
