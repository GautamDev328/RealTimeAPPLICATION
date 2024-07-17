using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface ICustomerPaymentRepository
    {
        public List<PaymentCustomerExtraUserModel> GetAllPaymewntCustomer();
        public void UpdatePaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser);
        public PaymentCustomerExtraUserModel SearchPaymentUser(int id);
        public void InsertPaymentCustomer(PaymentCustomerExtraUserModel paymentCustomerExtraUser);

    }
}
