using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticaEmployee.Models;

namespace AuthenticaEmployee.Interfaces
{
    interface IEmployeeContext
    {
        DbSet<EmployeeModel> Employees { get; set; }
    }
}
