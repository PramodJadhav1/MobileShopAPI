using MobileShopAPI.Entities;
using MobileShopAPI.Model;

namespace MobileShopAPI.Repositories
{
    public class PlaceOrderRepository : IPlaceOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public PlaceOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddPlaceOrder(PlaceOrder order)
        {
            _context.PlaceOrder.Add(order);
            int result = _context.SaveChanges();
            return result;
        }

        public int DeletePlaceOrder(int? id)
        {
            int res = 0;
            PlaceOrder O = _context.PlaceOrder.Where(x => x.Id == id).FirstOrDefault();
            if (O != null)
            {
                _context.PlaceOrder.Remove(O);
                res = _context.SaveChanges();
                return res;
            }
            else
            {
                return res;
            }
        }

        public IEnumerable<PlaceOrder> GetAllPlaceOrders()
        {
            return _context.PlaceOrder.ToList();
        }
        public PlaceOrder GetPlaceOrderById(int? id)
        {
            PlaceOrder O = _context.PlaceOrder.Find(id);
            return O;
        }

        public int UpdatePlaceOrder(PlaceOrder order)
        {
            int res = 0;
            PlaceOrder O = _context.PlaceOrder.Where(x => x.Id == order.Id).FirstOrDefault();
            if (O != null)
            {
                O.Name = order.Name;
                O.BrandName = order.BrandName;
                O.Address = order.Address;
                O.FromtoDate = order.FromtoDate;
                O.Price = order.Price;

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

