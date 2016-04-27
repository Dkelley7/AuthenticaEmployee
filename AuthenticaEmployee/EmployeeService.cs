using AuthenticaEmployee.Models;
using System;
using System.Collections.Generic;
using AuthenticaEmployee.Interfaces;

namespace AuthenticaEmployee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly  EmployeeContext _employeeContext;

        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        //Returns all Employees
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _employeeContext.Employees;
        }

        //Adds Users to Db
        public void AddEmployees()
        {
            _employeeContext.Employees.Add(new EmployeeModel() { FirstName = "David", LastName = "Kelley", Ssn = 123456789, Position = "Dev", DoB = new DateTime(1992, 7, 28) });
            _employeeContext.Employees.Add(new EmployeeModel() { FirstName = "Test", LastName = "User", Ssn = 987654321, Position = "Test", DoB = DateTime.Today });
            _employeeContext.SaveChanges();
        }

        //Truncates Employee table for testing purposes
        public void EmptyTable()
        {
            _employeeContext.Database.ExecuteSqlCommand("TRUNCATE TABLE [EmployeeModels]");
        }
    }
}