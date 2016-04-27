
using System.Collections.Generic;
using AuthenticaEmployee.Models;

namespace AuthenticaEmployee.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetEmployees();
        void AddEmployees();
        void EmptyTable();
    }
}
