using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Repositorries.Repositorries
{
    public class CartDetailRepositorries : ICartDetailRepositorries
    {
        private readonly QuanliwedContext _dbcontext;
        public CartDetailRepositorries(QuanliwedContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool AddCartDetail(CartDetail cartDetail)
        {
            try
            {
                _dbcontext.CartDetails.Add(cartDetail);
                _dbcontext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
            
        }

        public bool DelCartDetail(int Id)
        {
            try
            {
                var objdel = _dbcontext.CartDetails.Where(p => p.AccId.Equals(Id)).FirstOrDefault();
                if(objdel != null)
                {
                    _dbcontext.CartDetails.Remove(objdel);
                    _dbcontext.SaveChanges();
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DelCartDetail(CartDetail cartDetail)
        {
            try
            {
                _dbcontext.CartDetails.Remove(cartDetail);
                _dbcontext.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
               
            }
        }

        public async Task<List<CartDetail>> GetAllCartDetail()
        {
            return await _dbcontext.CartDetails.ToListAsync();
        }

        public async Task<CartDetail> GetCartDetailById(int Id)
        {
            return await _dbcontext.CartDetails.Where(p => p.AccId.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdateCartDetail(CartDetail cartDetail)
        {
            try
            {
                _dbcontext.CartDetails.Update(cartDetail);
                return true;

            }catch(Exception ex)
            {
                return false;
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
