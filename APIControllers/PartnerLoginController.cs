using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.APIControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PartnerLoginController : ControllerBase
	{
		public readonly PartnerLoginRepositroy partnerLoginRepositroy;
        public PartnerLoginController(PartnerLoginRepositroy _partnerLoginRepositroy)
        {
				this.partnerLoginRepositroy = _partnerLoginRepositroy;
        }
		[HttpGet("GetPartnerLogin")]
		public List<PartnerLogin> GetPartnerLogin()
		{
			var list=partnerLoginRepositroy.GetPartnerLogin();
			return list;
		}
		[HttpPost("CreatePartnerLogin")]
		public IActionResult  CreatePartnerLogin(PartnerLogin login)
		{
			 partnerLoginRepositroy.CreatePartnerLogin(login);
			return Ok(1);
		}
		[HttpPut("UpdatePartnerLogin")]
			public IActionResult UpdatePartnerLogin(PartnerLogin login)
		{
			partnerLoginRepositroy.UpdatePartnerLogin(login);
			return Ok(1);
		}
		[HttpDelete("DeletePartnerLogin")]
	        public IActionResult	DeletePartnerLogin(int id)
		{
		partnerLoginRepositroy.DeletePartnerLogin(id);
			return Ok(1);
		}
		[HttpGet("SearchPartnerLogin")]
	     public  IActionResult 	SearchPartnerLogin(int id)
		{
		var a= partnerLoginRepositroy.SearchPartnerLogin(id);
			return Ok(a);
		}

	}
}
