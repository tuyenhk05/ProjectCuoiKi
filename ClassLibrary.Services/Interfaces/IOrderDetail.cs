using ClassLibrary.Repositorries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Interfaces
{
    internal interface IOrderDetail
    {
        Task<List<IOrderDetail>> GetOrderDetailAsync();
        Task<int> AddOrderDetailAsync(int orderDetail);
        Task<int> RemoveOrderDetailAsync(int orderDetail);
        Task<bool> DeleteOrderDetailAsync(int orderDetail);
        Task<int> UpdateOrderDetailAsync(IOrderDetail orderDetail);
        Task<IList<OrderDetail>> OrderDetails();
    }
}