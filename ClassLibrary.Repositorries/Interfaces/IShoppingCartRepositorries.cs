using ClassLibrary.Repositorries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface IShoppingCartRepositorries
    {
        Task<List<ShoppingCart>> GetShoppingCart();
        Task<List<ShoppingCart>> GetShoppingCarts();
        Task<IList<ShoppingCart>> ToListAsync();
        Boolean DelShoppingCart(int shoppingCartId);
        int AddShoppingCart(ShoppingCart shoppingCart);
    }
}
