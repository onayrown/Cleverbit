using System;
using System.Collections.Generic;
using System.Text;

namespace CleverBit.CodingTask.Domain.Entities
{
    public class Employee
    {
        public Employee()
        {
            EmployeeId = Guid.NewGuid();
        }
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegionId { get; set; }

        public string GetFullName()
        {
            var fullName = new StringBuilder();
            fullName.Append(FirstName);
            fullName.Append(" ");
            fullName.Append(LastName);
            return fullName.ToString();
        }
    }
}
