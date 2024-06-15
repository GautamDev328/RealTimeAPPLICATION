using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeQueryController : ControllerBase
    {
        private readonly EmployeeQueryRepository employeeQueryRepository;
        public EmployeeQueryController(EmployeeQueryRepository _employeeQueryRepository)
        {

            this.employeeQueryRepository = _employeeQueryRepository;
        }
        [HttpGet("GetEmployeeQueryAll")]
        public List<EmployeeQuery> GetEmployeeQueryAll()
        {
            var list= employeeQueryRepository.GetEmployeeQueryAll();
            return list;
            }
    [HttpPost("CreateemployeeQuery")]

         public IActionResult  CreateEmployeeQuery(EmployeeQuery employeeQuery)
        {

            employeeQueryRepository.CreateEmployeeQuery(employeeQuery);
            return Ok(1);
        }
        [HttpPut("UpdateEmployeeQuery")]
        public IActionResult  UpdateEmployeeQuery(EmployeeQuery employeeQuery)
        {
             employeeQueryRepository.UpdateEmployeeQuery(employeeQuery);
                   return  Ok(1);

        }
        [HttpDelete("DeletesEmployeeQuery")]
        public IActionResult DeleteEmployeeQuery(int id)
        {
            employeeQueryRepository.DeleteEmployeeQuery(id);
            return Ok(1);

        }
        [HttpGet("DetailEmployeeQuery")]
        public EmployeeQuery DetailsEmployeeQuery(int id)
        {
            var  deltquery=employeeQueryRepository.DetailsEmployeeQuery(id);
            return deltquery;
        }

        [HttpGet("SearcgEmployeeQuery")]
        public EmployeeQuery SearchEmployeeQuery(int id)
        {
            var Searchquery = employeeQueryRepository.SearchById(id);
            return Searchquery;
        }



    }

}
