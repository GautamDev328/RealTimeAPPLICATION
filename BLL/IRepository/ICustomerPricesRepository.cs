using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.IRepository
{
    public interface ICustomerPricesRepository
    {
        public List<CustomerPrice> customerPrices();
        public void UpdateCustomerPrice(CustomerPrice customerPrice);
        public void DeleteCustomerPrice(int  Id);
        public CustomerPrice DetailsCustomerPrice(int  ID);
        public void CreateCustomerPrice(CustomerPrice customerPrice);
        public CustomerPrice  SeachById(int id);

    }
}
