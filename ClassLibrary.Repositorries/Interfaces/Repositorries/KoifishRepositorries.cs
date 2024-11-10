using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Interfaces.Repositorries
{
    public class KoifishRepositorries : IKoifishRepositorries
    {
        private readonly QuanliwedContext _dbContext;
        public KoifishRepositorries(QuanliwedContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddKoiFish(KoiFish koiFish)
        {
            throw new NotImplementedException();
        }



        public bool DelKoiFish(int koiFishId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KoiFish>> GetKoiFish()
        {
            return await _dbContext.KoiFishes.ToListAsync();
        }

        public async Task<List<KoiFish>> GetKoiFishs()
        {
            List<KoiFish>? koifishes = null;
            try
            {
                koifishes = await _dbContext.KoiFishes.ToListAsync();
            }
            catch (Exception ex)
            {
                koifishes?.Add(new KoiFish());
            }

            return koifishes;

        }

        public async Task<IList<KoiFish>> ToListAsync()
        {
            return await _dbContext.KoiFishes.ToListAsync();
        }
    }
}
