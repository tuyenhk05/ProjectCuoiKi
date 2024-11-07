using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    internal class CustomerSevices : ICustomer
    {
        public Task<int> AddCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ICustomer>> GetCustomerAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCustomerAsync(IKoifish customer)
        {
            throw new NotImplementedException();
        }
    }
}
