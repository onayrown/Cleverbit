using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleverBit.CodingTask.Domain.Models;
using CleverBit.CodingTask.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleverBit.CodingTask.Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        // GET: /region/233/employees
        [HttpGet("{id}/employees")]
        public ActionResult<List<EmployeesRegionsDTO>> Get()
        {
            var employeeService = new EmployeesService();
            var bode = employeeService.GetEmployeesRegionsById(233);
            return bode;
        }        

        // POST: api/Region
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Region/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private void GetEmployees(string path)
        {
            var employeeService = new EmployeesService();
            var bode = employeeService.GetEmployeesRegionsById(233);
        }
    }
}
