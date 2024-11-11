using ClassLibrary.Repositorries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repositorries.Interfaces
{
    public interface IEmployeeRepositorries
    {
        Task<List<Employee>> GetEmployee();
        Task<List<Employee>> GetEmployees();
        Task<IList<Employee>> ToListAsync();
        Boolean DelEmployee(int employeeId);
        int AddEmployee(Employee employeeId);
    }
}
