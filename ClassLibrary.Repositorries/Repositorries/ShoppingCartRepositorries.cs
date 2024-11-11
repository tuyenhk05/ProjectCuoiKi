using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Repositorries
{
    public class ShoppingCartRepositorries : IShoppingCartRepositorries
    {
        private readonly QuanliwedContext _dbContext;
        public ShoppingCartRepositorries(QuanliwedContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddShoppingCart(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public bool DelShoppingCart(int shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShoppingCart>> GetShoppingCart()
        {
            return await _dbContext.ShoppingCarts.ToListAsync();
        }

        public async Task<List<ShoppingCart>> GetShoppingCarts()
        {
            List<ShoppingCart>? shoppingCarts = null;
            try
            {
                shoppingCarts = await _dbContext.ShoppingCarts.ToListAsync();
            }
            catch (Exception ex) {
                shoppingCarts?.Add(new ShoppingCart());
            }
            return shoppingCarts;
        }

      
        public async Task<IList<ShoppingCart>> ToListAsync()
        {
            return await _dbContext.ShoppingCarts.ToListAsync();
        }
    }
}
