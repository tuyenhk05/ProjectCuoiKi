using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;

namespace ClassLibrary.Services.Interfaces
{
    public interface ICartDetail
    {
        Task<List<CartDetail>> CartDetails();
        Boolean DelCartDetail(int Id);
        Boolean DelCartDetail(CartDetail cartDetail);
        Boolean AddCartDetail(CartDetail cartDetail);
        Boolean UpdateCartDetail(CartDetail cartDetail);
        Task<CartDetail> GetCartDetailById(int Id);
    }
}
