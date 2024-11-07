using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Interfaces
{
    internal interface IEmployee
    {
        Task<List<IEmployee>> GetEmployeeAsync();
        Task<int> AddEmployeeAsync(int employeeId);
        Task<int> RemoveEmployeeAsync(int employeeId);
        Task<bool> DeleteEmployeeAsync(int employeeId);
        Task<int> UpdateEmployeeAsync(IEmployee employee);
        Task<IList<Employee>> Employees();
    }
}
