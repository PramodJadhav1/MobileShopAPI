using MobileShopAPI.Model;
using MobileShopAPI.Repositories;

namespace MobileShopAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;
        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public int AddCustomer(Customer customer)
        {
            return _repo.AddCustomer(customer);
        }

        public int DeleteCustomer(int? id)
        {
            return (_repo.DeleteCustomer(id));
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public Customer GetCustomerById(int? id)
        {
            return _repo.GetCustomerById(id);
        }

        public int UpdateCustomer(Customer customer)
        {
            return _repo.UpdateCustomer(customer);
        }
       
    }
}

