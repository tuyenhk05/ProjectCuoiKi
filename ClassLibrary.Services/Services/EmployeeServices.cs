using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    internal class EmployeeServices : IEmployee
    {
        public Task<int> AddEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Employee>> Employees()
        {
            throw new NotImplementedException();
        }

        public Task<List<IEmployee>> GetEmployeeAsync()
        {
            throw new NotImplementedException();
        }

       

        public Task<int> RemoveEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmployeeAsync(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
