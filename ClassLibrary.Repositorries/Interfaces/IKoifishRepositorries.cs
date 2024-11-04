using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface IKoifishRepositorries
    {
        Task<List<KoiFish>> GetKoiFish();
        Task<List<KoiFish>> GetKoiFishs();
        Task<IList<KoiFish>> ToListAsync();
        Boolean DelKoiFish(int koiFishId);
        int AddKoiFish(KoiFish koiFish);
    }
}
