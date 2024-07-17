using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerPricesController : ControllerBase
    {
        private readonly CustomerPricesRespository _customerPricesRepository;
        public CustomerPricesController(CustomerPricesRespository customerPricesRepository)
        {
            this._customerPricesRepository = customerPricesRepository;

        }
        [HttpGet("GetAllData")]
        public List<CustomerPrice> customerPrices()
        {
            var list = _customerPricesRepository.customerPrices();
            return list;
        }
        [HttpPost("CreateCustomerPrice")]
        public IActionResult CreateCustomerPrice(CustomerPrice customerPrice)
        {

            _customerPricesRepository.CreateCustomerPrice(customerPrice);
            return Ok(1);



        }
        [HttpPut("UpdateCustomerPrice")]
        public IActionResult UpdateCustomerPrice(CustomerPrice customerPrice)
        {
            _customerPricesRepository.UpdateCustomerPrice(customerPrice);
            return Ok(1);
        }
        [HttpDelete("DeleteCustomerPrice")]
        public IActionResult DeleteCustomerPrice(int Id)
        {
            _customerPricesRepository.DeleteCustomerPrice(Id);
            return Ok(1);
        }
        [HttpGet("DetailCustomerPrice")]
        public CustomerPrice DetailsCustomerPrice(int ID)
        {
            var details = _customerPricesRepository.DetailsCustomerPrice(ID);
            return details;
        }
        [HttpGet("SearchCustomerPrice")]

        public CustomerPrice SeachById(int id)
        {
            var search = _customerPricesRepository.DetailsCustomerPrice(id);
            return search;
        }



    }
}
