using System;
using System.Collections.Generic;
using System.Text;

namespace CleverBit.CodingTask.Domain.Models
{
    public class EmployeesRegionsDTO
    {
        public EmployeesRegionsDTO()
        {
            Regions = new List<string>();
        }

        public string EmployeeFullName { get; set; }
        public List<string> Regions { get; set; }
    }
}
