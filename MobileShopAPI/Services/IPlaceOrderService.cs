using MobileShopAPI.Model;

namespace MobileShopAPI.Services
{
    public interface IPlaceOrderService
    {
        IEnumerable<PlaceOrder> GetAllPlaceOrders();
        PlaceOrder GetPlaceOrderById(int? id);
        int AddPlaceOrder(PlaceOrder order);
        int UpdatePlaceOrder(PlaceOrder order);
        int DeletePlaceOrder(int? id);
    }
}
