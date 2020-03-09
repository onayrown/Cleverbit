using CleverBit.CodingTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleverBit.CodingTask.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        string GetEmployeeResourcePath();
    }
}
