using ClassLibrary.Repositorries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Services.Interfaces;

namespace ClassLibrary.Services.Services
{
    public class CartDetailServices : ICartDetail
    {
        private readonly ICartDetailRepositorries _repositorries;
        public CartDetailServices(ICartDetailRepositorries repositorries)
        {
            _repositorries = repositorries;
        }

        public bool AddCartDetail(CartDetail cartDetail)
        {
            return _repositorries.AddCartDetail(cartDetail);
        }

        public Task<List<CartDetail>> CartDetails()
        {
            return _repositorries.GetAllCartDetail();
        }

        public bool DelCartDetail(int Id)
        {
            return _repositorries.DelCartDetail(Id);
        }

        public bool DelCartDetail(CartDetail cartDetail)
        {
            return _repositorries.DelCartDetail(cartDetail);
        }

        public Task<CartDetail> GetCartDetailById(int Id)
        {
            return _repositorries.GetCartDetailById(Id);
        }

        public bool UpdateCartDetail(CartDetail cartDetail)
        {
            return _repositorries.UpdateCartDetail(cartDetail);
        }
    }
}
