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
        public IActionResult CreateState(StateModel state)
        {
            stateRepository.CreateState(state);
                return Ok(1);

        }
        [HttpPut("UpdateState")]
        public IActionResult UpdateState(StateModel state)
        {
            stateRepository.UpdateState(state);
            return Ok(1);
        }
        [HttpDelete("DeleteState")]
        public IActionResult DeleteState(int id)
        {
           stateRepository.DeleteState(id); 
            return Ok(1);
        }
        [HttpGet("DetailState")]
        public StateModel DetailsState(int id)
        {
            var state = stateRepository.DetailsState(id);
            return state;
        }
        [HttpGet("SearchState")]
        public StateModel SearchStates(int id)
        {
            var search = stateRepository.SeachById(id);
            return search;
        }


    }

    }

