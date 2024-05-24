using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentRepository _DepartmentRepository;
        public DepartmentController(DepartmentRepository DepartmentRepository)
        {
                this._DepartmentRepository = DepartmentRepository;
        }

        [HttpPost("CreateDepartment")]
        public void CreateDepartment(Department department)
        {
            _DepartmentRepository.CreateDepartment(department);

        }
        [HttpGet("ALLDATADepartment")]
        public List<Department> GetAllDepartmentData()
        {
            var list = _DepartmentRepository.GetAllDepartmentData();
            return list;
        }
    }

}
