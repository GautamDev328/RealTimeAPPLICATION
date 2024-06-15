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
        public IActionResult CreateDesignation(DesignationModel designationModel)
        {
            _designationRepository.CreateDesignation(designationModel);
            return Ok(1);

        }
        [HttpGet("ALLDATADesignation")]
        public List<DesignationModel> GetALLDesignationData()
        {
            var list = _designationRepository.GetALLDesignationData();
            return list;
        }
        [HttpPut("UpdateDesignation")]
        public IActionResult UpdateDesignationModel(DesignationModel designationModel)
        {
            _designationRepository.UpdateDesignationModel(designationModel);
            return Ok(1);
        }
        [HttpDelete("DeleteDesignation")]
        public IActionResult DeleteDesignationModel(int id)
        {
            _designationRepository.DeleteDesignationModel(id);
            return Ok(1);
        }
        [HttpGet("SearchDesignaiton")]
        public DesignationModel SearchById(int id)
        {
            var search = _designationRepository.SearchById(id);
            return search;
        }
        [HttpGet("DetailDesignaiton")]

        public DesignationModel DetailsDesignationModel(int id)
        {
            var details = _designationRepository.SearchById(id);
            return details;
        }




    }
}
