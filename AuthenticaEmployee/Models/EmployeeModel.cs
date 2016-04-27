using System;

namespace AuthenticaEmployee.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public DateTime DoB { get; set; }
        public string Position { get; set; }

    }
}