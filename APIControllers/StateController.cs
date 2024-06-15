using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly StateRepository stateRepository;
        public StateController(StateRepository _stateRepository)
        {
            this.stateRepository = _stateRepository;
        }

        [HttpGet("ListAllData")]
        public List<StateModel> states()
        {
            var a = stateRepository.states();
            return a;
        }
        [HttpPost("CreateState")]
        public void CreateState(StateModel state)
        {
            stateRepository.CreateState(state);
            //  return Ok(1);

        }
    }

}