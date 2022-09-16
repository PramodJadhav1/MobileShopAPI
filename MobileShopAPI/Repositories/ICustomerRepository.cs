using MobileShopAPI.Model;

namespace MobileShopAPI.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int? id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer Customer);
        int DeleteCustomer(int? id);
        
    }
}
