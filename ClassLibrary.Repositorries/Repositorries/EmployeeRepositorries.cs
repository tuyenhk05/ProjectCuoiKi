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
    public class EmployeeRepositorries : IEmployeeRepositorries
    {
        private readonly QuanliwedContext _dbContext;
        public EmployeeRepositorries(QuanliwedContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddEmployee(Employee employeeId)
        {
            throw new NotImplementedException();
        }

        public bool DelEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee>? employee = null;
            try
            {
                employee = await _dbContext.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                employee?.Add(new Employee());
            }

            return employee;
        }

        public async Task<IList<Employee>> ToListAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
    }
}
