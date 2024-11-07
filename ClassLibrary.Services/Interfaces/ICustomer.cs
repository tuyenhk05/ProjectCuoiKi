using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Interfaces
{
    internal interface ICustomer
    {
        Task<List<ICustomer>> GetCustomerAsync();
        Task<int> AddCustomerAsync(int customerId);
        Task<int> RemoveCustomerAsync(int customerId);
        Task<bool> DeleteCustomerAsync(int customerId);
        Task<int> UpdateCustomerAsync(IKoifish customer);
    }
}
