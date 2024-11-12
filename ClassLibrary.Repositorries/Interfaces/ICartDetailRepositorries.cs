using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface ICartDetailRepositorries
    {
        Task<List<CartDetail>> GetAllCartDetail();
        Boolean DelCartDetail(int Id);
        Boolean DelCartDetail(CartDetail cartDetail);
        Boolean AddCartDetail(CartDetail cartDetail);
        Boolean UpdateCartDetail(CartDetail cartDetail);
        Task<CartDetail> GetCartDetailById(int Id);
    }
}
