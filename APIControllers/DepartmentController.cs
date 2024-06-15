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
        [HttpPut("UpdateDepartment")]
        public IActionResult UpdateDepartment(Department department)
        {
             _DepartmentRepository.UpdateDepartment(department);
            return Ok(1);
        }
        [HttpDelete("DeleteDepartment")]
        public IActionResult DeleteDepartment(int id)
        {
            _DepartmentRepository.DeleteDepartment(id);
            return Ok(1);
        }
      
        [HttpGet("DetailDepartment")]
        public Department DetailsDepartments(int id)
        {
          var dep= _DepartmentRepository.DetailsDepartments(id);
            return dep;
        }
        [HttpGet("SearchDepartment")]
        public Department SearchDepartments(int id)
        {
            var search = _DepartmentRepository.SearchById(id);
            return search;
        }



    }

}
