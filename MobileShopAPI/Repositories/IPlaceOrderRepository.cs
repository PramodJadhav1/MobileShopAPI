using MobileShopAPI.Model;

namespace MobileShopAPI.Repositories
{
    public interface IPlaceOrderRepository
    {
        IEnumerable<PlaceOrder> GetAllPlaceOrders();
        PlaceOrder GetPlaceOrderById(int? id);
        int AddPlaceOrder(PlaceOrder order);
        int UpdatePlaceOrder(PlaceOrder order);
        int DeletePlaceOrder(int? id);
    }
}
