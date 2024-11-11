using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    public class CustomerSevices : ICustomer
    {
        private readonly ICustomerRepositorries _customerRepositorries;
        public CustomerSevices(ICustomerRepositorries customerRepositorries)
        {
            _customerRepositorries = customerRepositorries;
        }
        public Task<int> AddCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomerAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        Task<List<ICustomer>> ICustomer.GetCustomerAsync()
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
