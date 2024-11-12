using System;
using Order.Repositorries.Entities
namespace Order.Repositorries.Interfaces
{
    public interface IOrderRepositorries
    {
        Task<List<Order>> GetAllOrder();
        Boolean DelOrder(int Id);
        Boolean DelOrder(Order account);
        Boolean AddOrder(Order account);
        Boolean UpdOrder(Order account);
        Task<Order> GetOrderById(int Id);
    }
}

