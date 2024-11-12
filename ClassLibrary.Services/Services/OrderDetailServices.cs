using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Repositorries.Repositorries;
using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    public class OrderDetailServices : IOrderDetail
        private readonly IOrderDetailRepositorries _orderDetailRepositorries;
        public OrderDetailSevices(IOrderDetailRepositorries orderDetailRepositorries)
        {
             _orderDetailRepositorries = orderDetailRepositorries;
        }
        public Task<int> AddOrderDetailAsync(int orderDetailId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrderDetailAsync(int orderDetailId)
        {
            throw new NotImplementedException();
        }

        Task<List<IOrderDetail>> IOrderDetail.GetOrderDetailAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveOrderDetailAsync(int orderDetailId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCustomerAsync(IKoifish customer)
        {
            throw new NotImplementedException();
        }
    
}