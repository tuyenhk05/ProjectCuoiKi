using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    internal class ShoppingCartServices : IShoppingCart
    {
        public Task<int> AddShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public Task<List<IShoppingCart>> GetShoppingCartAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ShoppingCart>> ShoppingCarts()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateShoppingCartAsync(IShoppingCart shoppingcart)
        {
            throw new NotImplementedException();
        }
    }
}
