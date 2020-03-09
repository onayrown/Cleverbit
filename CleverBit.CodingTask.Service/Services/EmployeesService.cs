using CleverBit.CodingTask.Domain.Models;
using CleverBit.CodingTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CleverBit.CodingTask.Domain.Services
{
    public class EmployeesService
    {
        private const string pathRegions = @"E:\Dev\CleverBit\Resources\regions.csv";
        private const string pathEmployees = @"E:\Dev\CleverBit\Resources\employees.csv";
        public List<Employee> GetEmployeesFromCsv(string path)
        {
            var employees = File.ReadAllLines(path).Select(a => a.Split(',')).ToList()
                .Select(c => new Employee()
                {
                    RegionId = ValidateStringNumber(c[0]),
                    FirstName = c[1].ToString(),
                    LastName = c[2].ToString()
                }).ToList();

            return employees.ToList();
        }
        public List<Region> GetRegionsFromCsv(string path)
        {
            var regions = File.ReadAllLines(path).Select(a => a.Split(',')).ToList()
                .Select(c => new Region()
                {
                    Name = c[0].ToString(),
                    RegionId = ValidateStringNumber(c[1]),
                    ParentId = ValidateStringNumber(c[2])
                }).ToList();

            return regions.ToList();
        }
        public List<EmployeesRegionsDTO> GetEmployeesRegionsById(int regionId)
        {
            var employeesRegionsList = new List<EmployeesRegionsDTO>();           
            var employees = GetEmployeesFromCsv(pathEmployees).Where(e => e.RegionId == regionId);
            var regionOriginal = GetRegionsFromCsv(pathRegions).FirstOrDefault(r => r.RegionId == regionId);

            foreach (var employee in employees)
            {
                var employeesRegions = new EmployeesRegionsDTO();
                var region = regionOriginal;
                employeesRegions.Regions.Add(region.Name);
                employeesRegions.EmployeeFullName = employee.GetFullName();

                while (!region.IsParent())
                {
                    region = GetRegionsFromCsv(pathRegions).FirstOrDefault(r => r.RegionId == region.ParentId);
                    employeesRegions.Regions.Add(region.Name);
                }
                employeesRegionsList.Add(employeesRegions);
            }
                                  
            return employeesRegionsList;
        }        
        private int ValidateStringNumber(string strNumber)
        {
            int value;
            if (!int.TryParse(strNumber, out value))
            {
                return 0;
            }

            return value;
        }         
    }
}
