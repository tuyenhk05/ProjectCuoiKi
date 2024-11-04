using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Services.Interfaces;
using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;

namespace ClassLibrary.Services.Services
{
    public class KoifishServices : IKoifish
    {
        private readonly IKoifishRepositorries _koifishRepositorries;
        public KoifishServices(IKoifishRepositorries koifishRepositorries) {
          _koifishRepositorries = koifishRepositorries;
        }

        public Task<int> AddKoifishAsync(int koifishId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteKoifishAsync(int kifishId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KoiFish>> GetKoiFishAsync()
        {
            return await _koifishRepositorries.GetKoiFishs();
        }

        public Task<List<IKoifish>> GetKoifishAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<KoiFish>> KoiFishs()
        {
            return await _koifishRepositorries.ToListAsync();
        }

        public Task<int> RemoveKoifishAsync(int kifishId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateKoifishAsync(IKoifish koifish)
        {
            throw new NotImplementedException();
        }
    }
}
