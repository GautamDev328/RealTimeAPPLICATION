using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
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
            this._relationRepository = relationRepository;
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
    }
}
