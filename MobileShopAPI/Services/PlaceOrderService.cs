using MobileShopAPI.Model;
using MobileShopAPI.Repositories;

namespace MobileShopAPI.Services
{
    public class PlaceOrderService : IPlaceOrderService
    {
        private readonly IPlaceOrderRepository _repo;
        public PlaceOrderService(IPlaceOrderRepository repo)
        {
            _repo = repo;
        }
        public int AddPlaceOrder(PlaceOrder order)
        {
            return _repo.AddPlaceOrder(order);
        }

        public int DeletePlaceOrder(int? id)
        {
            return (_repo.DeletePlaceOrder(id));
        }

        public IEnumerable<PlaceOrder> GetAllPlaceOrders()
        {
            return _repo.GetAllPlaceOrders();
        }

        public PlaceOrder GetPlaceOrderById(int? id)
        {
            return _repo.GetPlaceOrderById(id);
        }

        public int UpdatePlaceOrder(PlaceOrder order)
        {
            return _repo.UpdatePlaceOrder(order);
        }

    }
}
