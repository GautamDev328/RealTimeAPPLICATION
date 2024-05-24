//using CRUDAPPLICATION.BLL.Repository;
//using CRUDAPPLICATION.Model;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace CRUDAPPLICATION.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HRLOGINController : ControllerBase
//    {
//        private readonly HRLOGINRESPOROTY _HRLoginRepository;
//        public HRLOGINController(HRLOGINRESPOROTY HRLoginRepository)
//        {
//            this._HRLoginRepository = _HRLoginRepository;   
//        }
//        [HttpPost("CreateHRLogin")]
//        public void CreateHRLogin(HRLOGIN hRLOGIN)
//        {
//            _HRLoginRepository.CreateHRLogin(hRLOGIN);

//        }
//        [HttpGet("ALLDATAHRLOGIN")]
//        public List<HRLOGIN> GetHrLoginAll()
//        {
//            var list = _HRLoginRepository.GetHrLoginAll();
//            return list;
//        }
//    }
//}
