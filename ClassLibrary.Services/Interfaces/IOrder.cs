using System;
using ClassLibrary.Repositorries.Entities;
namespace ClassLibrary.Services.Interfaces
{
    public interface IOrder
    {
        Task<List<IOrder>> Order();
        Boolean DelOrder(int Id);
        Boolean DelOrder(Order account);
        Boolean AddOrder(Order account);
        Boolean UpdOrder(Order account);
        Task<Order> GetOrderById(int Id);
    }
}
