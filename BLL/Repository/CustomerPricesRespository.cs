using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;

namespace CRUDAPPLICATION.BLL.Repository
{
    public class CustomerPricesRespository : ICustomerPricesRepository
    {
        EmployeeDbContext _employeeDbContext;
        public CustomerPricesRespository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;

        }

        public void CreateCustomerPrice(CustomerPrice customerPrice)
        {
            _employeeDbContext.customerPrices.Add(customerPrice);
            _employeeDbContext.SaveChanges();
        }

        public List<CustomerPrice> customerPrices()
        {
            var list = _employeeDbContext.customerPrices.ToList();
            return list;
        }

        public void DeleteCustomerPrice(int Id)
        {
            var delete = _employeeDbContext.customerPrices.Where(s => s.Id == Id).FirstOrDefault();
                         _employeeDbContext.customerPrices.Remove(delete);
            _employeeDbContext.SaveChanges();
        }

        public CustomerPrice DetailsCustomerPrice(int ID)
        {
            var a= _employeeDbContext.customerPrices.Where(s=>s.Id == ID).FirstOrDefault();
            return a;
        }

        public CustomerPrice SeachById(int id)
        {
            var a = _employeeDbContext.customerPrices.Where(s => s.Id == id).FirstOrDefault();
            return a;
        }

        public void UpdateCustomerPrice(CustomerPrice customerPrice)
        {
       _employeeDbContext.customerPrices.Update(customerPrice);
               _employeeDbContext.SaveChanges();
        }
    }
}
