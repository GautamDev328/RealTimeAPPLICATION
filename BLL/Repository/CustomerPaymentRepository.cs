using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class CustomerPaymentRepository : ICustomerPaymentRepository
    {
        private EmployeeDbContext employeeDbContext;
        public CustomerPaymentRepository(EmployeeDbContext _employeeDbContext)
        {
            this.employeeDbContext = _employeeDbContext;
        }
        public List<PaymentCustomerExtraUserModel> GetAllPaymewntCustomer()
        {
            var list = employeeDbContext.paymentCustomeExtraUserModels.ToList();
            return list;
        }
        public void UpdatePaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser)
        {
            employeeDbContext.paymentCustomeExtraUserModels.Update(paymentCustomerExtraUser);
            employeeDbContext.SaveChanges();
        }
        public PaymentCustomerExtraUserModel SearchPaymentUser(int id)
        {
            //var search = employeeDbContext.paymentCustomeExtraUserModels.Where(s => s.paymentId ==id).FirstOrDefault();
            var search= employeeDbContext.paymentCustomeExtraUserModels.Where(s=>s.id==id).FirstOrDefault();
            return search;
          //  return search;
        }
        public void InsertPaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser)
        {
            employeeDbContext.paymentCustomeExtraUserModels.Add(paymentCustomerExtraUser);
            employeeDbContext.SaveChanges();
        }
    }
}
