using ClassLibrary.Repositorries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface ICustomerRepositorries
    {
        Task<List<Customer>> GetCustomer();
        Task<List<Customer>> GetCustomers();
        Task<IList<Customer>> ToListAsync();
        Boolean DelCustomer(int customerId);
        int AddCustomer(Customer customerId);
    }
}
