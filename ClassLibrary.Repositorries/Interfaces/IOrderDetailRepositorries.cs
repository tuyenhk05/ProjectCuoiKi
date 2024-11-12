using ClassLibrary.Repositorries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface IOrderDetailRepositorries
    {
       {
        Task<List<OrderDetail>> GetOrderDetail();
        Task<List<OrderDetail>> GetOrderDetail();
        Task<IList<OrderDetail>> ToListAsync();
        Boolean DelOrderDetail(int orderDetailId);
        int AddOrderDetail(OrderDetail orderDetail);
    }
}
