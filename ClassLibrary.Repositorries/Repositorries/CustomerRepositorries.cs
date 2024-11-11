using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Repositorries
{
    public class CustomerRepositorries : ICustomerRepositorries
    {
        private readonly QuanliwedContext _dbContext;
        public CustomerRepositorries(QuanliwedContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddCustomer(Customer customerId)
        {
            throw new NotImplementedException();
        }

        public bool DelCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetCustomer()
        {
          return await _dbContext.Customers.ToListAsync();
        }

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer>? customer = null;
            try
            {
                customer = await _dbContext.Customers.ToListAsync();
            }
            catch (Exception ex)
            {
                customer?.Add(new Customer());
            }

            return customer;
        }

        public async Task<IList<Customer>> ToListAsync()
        {
            return await _dbContext.Customers.ToListAsync();
        }
    }
}
