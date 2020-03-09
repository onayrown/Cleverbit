using CleverBit.CodingTask.Domain.Entities;
using CleverBit.CodingTask.Domain.Services;
using CleverBit.CodingTask.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CleverBit.CodingTask.Web.Controllers
{    
    public class EmployeeController : Controller
    {
        private const string pathRegions = @"E:\Dev\CleverBit\Resources\regions.csv";
        private const string pathEmployees = @"E:\Dev\CleverBit\Resources\employees.csv";
        public IActionResult Index()
        {
            var vm = new RegionViewModelDTO();
            var service = new EmployeesService();
            var regions = service.GetRegionsFromCsv(pathRegions);

            vm.Regions = new List<SelectListItem>();

            foreach (var region in regions)
            {
                var item = new SelectListItem { Text = region.Name, Value = region.RegionId.ToString() };
                vm.Regions.Add(item);
            }

            return View(vm);
        }
        
        public IActionResult Create()
        {
            var vm = new RegionViewModelDTO();
            vm.Regions = new List<SelectListItem>
            {
                new SelectListItem {Text = "Shyju", Value = "1"},
                new SelectListItem {Text = "Sean", Value = "2"}
            };

            return View(vm);
        }


        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var e = employee;

            return RedirectToAction("Create");
        }
    }
}
