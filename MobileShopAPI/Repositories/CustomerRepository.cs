using MobileShopAPI.Entities;
using MobileShopAPI.Model;
using MobileShopAPI.Repositories;

namespace MobileShopAPI.Repositories
{
   public class CustomerRepository : ICustomerRepository
    {
     private readonly ApplicationDbContext _context;
     public CustomerRepository(ApplicationDbContext context)
     {
                _context = context;
            }
            public int AddCustomer(Customer customer)
            {
                _context.Customer.Add(customer);
                int result = _context.SaveChanges();
                return result;
            }

            public int DeleteCustomer(int? id)
            {
                int res = 0;
                Customer c = _context.Customer.Where(x => x.Id == id).FirstOrDefault();
                if (c != null)
                {
                    _context.Customer.Remove(c);
                    res = _context.SaveChanges();
                    return res;
                }
                else
                {
                    return res;
                }
            }

            public IEnumerable<Customer> GetAllCustomers()
            {
                return _context.Customer.ToList();
            }
            public Customer GetCustomerById(int? id)
            {
                Customer c = _context.Customer.Find(id);
                return c;
            }

            public int UpdateCustomer(Customer customer)
            {
                int res = 0;
                Customer c = _context.Customer.Where(x => x.Id == customer.Id).FirstOrDefault();
                if (c != null)
                {
                    c.CName = customer.CName;
                    c.Gender =customer.Gender;
                    c.Contact = customer.Contact;
                    c.CAddress = customer.CAddress;
                    c.Email = customer.Email;
                    c.Password = customer.Password;

                    res = _context.SaveChanges();
                    return res;
                }
                else
                {
                    return res;
                }
            }
        
    }
}
