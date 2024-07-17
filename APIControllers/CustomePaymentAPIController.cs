using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPPLICATION.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomePaymentAPIController : ControllerBase
    {
        private readonly CustomerPaymentRepository customePaymentRepository;
        public CustomePaymentAPIController(CustomerPaymentRepository _customePaymentRepository)
        {
            this.customePaymentRepository = _customePaymentRepository;
        }
        [HttpGet("AllPaymentDataList")]
        public List<PaymentCustomerExtraUserModel> GetAllPaymewntCustomer()
        {
            var list = customePaymentRepository.GetAllPaymewntCustomer();
            return list;
        }
        //[HttpPut("UpdatePaymentData")]
        //public IActionResult  UpdatePaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser)
        //{
        //  customePaymentRepository.UpdatePaymentCustomer(paymentCustomerExtraUser);
        //    return Ok(1);

        //}
        [HttpPut("UpdatePaymentData")]
        public IActionResult UpdatePaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser)
        {
            // Fetch the existing entity from the repository
            //var existingEntity = customePaymentRepository.SearchPaymentUser(paymentCustomerExtraUser.paymentId) ;

            //if (existingEntity == null)
            //{
            //    return NotFound("Payment customer not found");
            //}

            //// Update only the Device_Serials property
            //existingEntity.Device_Serials = paymentCustomerExtraUser.Device_Serials;

            // Save the updated entity back to the repository
            customePaymentRepository.UpdatePaymentCustomer(paymentCustomerExtraUser);

            return Ok(1);
        }

        [HttpGet("SearchPaymentData")]
        public PaymentCustomerExtraUserModel SearchPaymentUser(int id)
        {
            var search=customePaymentRepository.SearchPaymentUser(id);
            return search;
        }
        [HttpPost("CreatePaymentCustomer")]
        public IActionResult InsertPaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser)
        {
            //customePaymentRepository.InsertPaymentCustomer(paymentCustomerExtraUser);
            //return Ok(1);
            //var newPaymentCustomer = new PaymentCustomerExtraUserModel
            //{
            //    Device_Serials = paymentCustomerExtraUser.Device_Serials
            //};

            // Insert the new instance into the repository
            customePaymentRepository.InsertPaymentCustomer(paymentCustomerExtraUser);

            return Ok(1);

        }
    }
}
