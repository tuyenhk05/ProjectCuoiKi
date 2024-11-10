using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Repositorries.Entities;

namespace ClassLibrary.Services.Interfaces
{
    public interface IKoifish
    {
        Task<List<IKoifish>> GetKoifishAsync();
        Task<int> AddKoifishAsync(int koifishId);
        Task<int> RemoveKoifishAsync(int kifishId);
        Task<bool> DeleteKoifishAsync(int kifishId);
        Task<int>UpdateKoifishAsync(IKoifish koifish);
        Task<IList<KoiFish>> KoiFishs();
    }
}
