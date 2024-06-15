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

    public void  CreateEmployeeQuery(EmployeeQuery employeeQuery)
        {

            employeeQueryRepository.CreateEmployeeQuery(employeeQuery);
        }

             

    }
    
}
