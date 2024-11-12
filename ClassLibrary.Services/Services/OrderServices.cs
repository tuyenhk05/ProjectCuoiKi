using System;
namespace ClassLibrary.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderServicesRepositorries _repositorries;
        public OrderServices(IOrderServicesRepositorries repositorries)
        {
            _repositorries = repositorries
        }

        public bool AddOrder(Order)
        {
            return _repositorries.AddOrder();
        }

        public bool DelOrder(int Id)
        {
            return _repositorries.DelOrder(Id);
        }

        public bool DelOrder(Order account)
        {
            return _repositorries.DeOrder(account);
        }

        public Task<List<Order>> GetOrderById()
        {
            return _repositorries.GetOrderById(Id);
        }

        public Task<List<Order>> GetAllOrderById()
        {
            return _repositorries.GetAllOrder();
        }

        public bool UpdOrder(OrderServices account)
        {
            return _repositorries.UpdOrder(account);
        }
    }
}

