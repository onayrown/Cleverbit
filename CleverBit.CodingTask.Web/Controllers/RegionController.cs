using CleverBit.CodingTask.Domain.Entities;
using CleverBit.CodingTask.Domain.Models;
using CleverBit.CodingTask.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverBit.CodingTask.Web.Controllers
{
    [Route("[controller]")]
    public class RegionController : Controller
    {
        [HttpGet("{id}/employees")]
        public ActionResult<List<EmployeesRegionsDTO>> Employees(int id)
        {
            var employeeService = new EmployeesService();
            var bode = employeeService.GetEmployeesRegionsById(id);
            return bode;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Region region)
        {
            var r = region;
            return RedirectToAction("Index", "Employee");
        }
    }
}
