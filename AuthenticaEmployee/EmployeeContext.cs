using AuthenticaEmployee.Models;
using System.Data.Entity;
using AuthenticaEmployee.Interfaces;

namespace AuthenticaEmployee
{
    public class EmployeeContext : DbContext, IEmployeeContext
    {
      
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}