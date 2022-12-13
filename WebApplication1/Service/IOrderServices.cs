using WebApplication1.Model.Entity;

namespace WebApplication1.Service
{
    public interface IOrderServices
    {
        List<Order> GetAllOrders();
        Order GetOrder(int id);
        Order AddOrder(Order order);
        void DeleteOrderById(int id);
        void UpdateOrder(Order order);
    }
}
