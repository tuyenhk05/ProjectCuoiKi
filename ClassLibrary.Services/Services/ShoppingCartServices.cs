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
    public class ShoppingCartServices : IShoppingCart
    {
        private readonly IShoppingCartRepositorries _shoppingCartRepositorries;

        public ShoppingCartServices(IShoppingCartRepositorries ShoppingCartRepositorries)
        {
            ShoppingCartRepositorries = _shoppingCartRepositorries;
        }


        public Task<int> AddShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ShoppingCart>> GetShoppingCartAsync()
        {
            return await _shoppingCartRepositorries.GetShoppingCarts();
        }
        public Task<int> RemoveShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ShoppingCart>> ShoppingCarts()
        {
            throw new NotImplementedException();
        }


        Task<int> IShoppingCart.AddShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IShoppingCart.DeleteShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        Task<List<IShoppingCart>> IShoppingCart.GetShoppingCartAsync()
        {
            throw new NotImplementedException();
        }

        Task<int> IShoppingCart.RemoveShoppingCartAsync(int shoppingcartId)
        {
            throw new NotImplementedException();
        }

        Task<IList<ShoppingCart>> IShoppingCart.ShoppingCarts()
        {
            throw new NotImplementedException();
        }

        Task<int> IShoppingCart.UpdateShoppingCartAsync(IShoppingCart shoppingcart)
        {
            throw new NotImplementedException();
        }
    }
}
