using System;
using Microsoft.EntityFrameworkCore;
using Order.Repositorries.Entities;
using Order.Repositorries.Interface;

namespace Order.Repositorries
{
    public class OrderRepositorries : IOrderRepositorries
    {
        private readonly QuanliwebContext _context;

        public OrderRepositorries(QuanliwebContext _context)
        {
            _context = _context;
        }

        public async Task<List<Order>> GetAllOrder();
        {
            return await _Context.Order.ToListAsync();
    }
}
public interface AddOrder(int OrderId)
{
            throw new NotImplementedException();
}
public bool DelOrder(int OrderId)
{
    throw new NotImplementedException();
}
public async Task<List<Order>> GetAllOrder();
{
    List<Order>? Order = null;
    try
    {
        order = await _dbContext.Order.ToListAsync();
    }
    catch (Exception ex)
    {
        order?.Add(new Order());
    }
    return Order;
}
public async Task<List<Order>> ToListAsync();
{
    return await _dbContext.Order.ToListasync();
}
   }
}
