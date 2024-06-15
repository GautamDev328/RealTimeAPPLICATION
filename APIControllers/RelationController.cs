using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelationController : ControllerBase
    {
        private readonly RELATIONREPOSITORY _relationRepository;
        public RelationController(RELATIONREPOSITORY relationRepository)
        {
               this._relationRepository=relationRepository;
        }
        [HttpPost("CreateRelaiton")]
        public void CreateRelaitonModel(RelationModel relationModel)
        {
            _relationRepository.CreateRelaitonModel(relationModel);

        }
        [HttpGet("ALLDATARelation")]
        public List<RelationModel> GetRelationModelAll()
        {
            var list = _relationRepository.GetRelationModelAll();
            return list;
        }
        [HttpPut("UpdatesRelation")]
        public IActionResult UpdateRelaiton(RelationModel relationModel)
        {
            _relationRepository.UpdateRelaitonModel(relationModel);
            return Ok(1);

        }
        [HttpGet("DetailsRelation")]
        public RelationModel DetailsRelaitonModel(int id)
        {
            var delt = _relationRepository.DetailsRelaitonModel(id);
            return delt;
        }
        [HttpDelete("DeleteRelation")]
        public IActionResult DeleteRelaitonModel(int id)
        {
            _relationRepository.DeleteRelaitonModel(id);
            return Ok(1);
        }
        [HttpGet("SearchRelation")]
        public RelationModel SeachById(int id)
        {
            var delt = _relationRepository.SeachById(id);
            return delt;
        }

    }
}
