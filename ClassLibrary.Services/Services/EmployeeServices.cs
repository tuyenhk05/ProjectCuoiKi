using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Services
{
    public class EmployeeServices : IEmployee
    {
        private readonly IEmployeeRepositorries _employeeRepositorries;
        public EmployeeServices(IEmployeeRepositorries employeeRepositorries)
        {
            _employeeRepositorries = employeeRepositorries;
        }
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

      
       

        public Task<int> RemoveEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<int> IEmployee.AddEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IEmployee.DeleteEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<IList<Employee>> IEmployee.Employees()
        {
            throw new NotImplementedException();
        }

        Task<List<IEmployee>> IEmployee.GetEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        Task<int> IEmployee.RemoveEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        Task<int> IEmployee.UpdateEmployeeAsync(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
