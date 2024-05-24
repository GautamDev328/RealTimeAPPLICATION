using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DesignationController : ControllerBase
    {
        private readonly DesignationRepository _designationRepository;
        public DesignationController(DesignationRepository designationRepository)
        {
            this._designationRepository = designationRepository;
                
        }
        [HttpPost("CreateDesignation")]
        public void CreateDesignation(DesignationModel designationModel)
        {
            _designationRepository.CreateDesignation(designationModel);

        }
        [HttpGet("ALLDATADesignation")]
        public List<DesignationModel> GetALLDesignationData()
        {
            var list = _designationRepository.GetALLDesignationData();
            return list;
        }
    }
}
