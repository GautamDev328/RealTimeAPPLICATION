//using CRUDAPPLICATION.BLL;
using CRUDAPPLICATION.BLL;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    // [ApiController]
    public class EmployeeProfileController : ControllerBase
    {

        private readonly EmployeeRepository _employeeRepository;

        public EmployeeProfileController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        [HttpGet("ListAllData")]
        public List<EmployeeProfile> GetEmployees()
        {
            var a = _employeeRepository.GetAll();
            return a;
        }

        //[HttpDelete("Delete")]
        //public IActionResult Delete(int id)
        //{
        //    var deletedProfile = _employeeRepository.delete(id);
        //    if (deletedProfile == null)
        //    {
        //        return NotFound(); // Return 404 Not Found if the profile with the given id was not found
        //    }
        //    return Ok(deletedProfile); // Return the deleted profile
        //}

        [HttpPut("UpdateData")]
        public IActionResult update(EmployeeProfile employeeProfile)
        {
            _employeeRepository.update(employeeProfile);
            return Ok(1);
        }

        //[HttpGet("SeachById")]
        //public IActionResult Search(int id)
        //{
        //    var a=_employeeRepository.Search(id);
        //    return Ok(a);
        //}

        [HttpPost("CreateEmployee")]
        public IActionResult insert(EmployeeProfile employeeProfile)
        {
            try
            {
                _employeeRepository.insert(employeeProfile);
                return Ok(1); // Return 200 OK if insertion is successful
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while inserting the employee: {ex.Message}");
                // Return 500 Internal Server Error if an exception occurs during insertion
            }
        }
    }
}


      