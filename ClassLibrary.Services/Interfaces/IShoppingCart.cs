using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Interfaces
{
    internal interface IShoppingCart
    {
        Task<List<IShoppingCart>> GetShoppingCartAsync();
        Task<int> AddShoppingCartAsync(int shoppingcartId);
        Task<int> RemoveShoppingCartAsync(int shoppingcartId);
        Task<bool> DeleteShoppingCartAsync(int shoppingcartId);
        Task<int> UpdateShoppingCartAsync(IShoppingCart shoppingcart);
        Task<IList<ShoppingCart>> ShoppingCarts();
    }
}
