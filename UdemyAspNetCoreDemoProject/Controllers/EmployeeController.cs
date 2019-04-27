using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UdemyAspNetCoreDemoProject.Entities;
using UdemyAspNetCoreDemoProject.Models;

namespace UdemyAspNetCoreDemoProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ Id = 123, Name = "Hamdi Çatal", CityId = 6 },
                new Employee{ Id = 131, Name = "Ali Can", CityId = 7 },
                new Employee{ Id = 142, Name = "Ayşe Demir", CityId = 34 },
                new Employee{ Id = 120, Name = "Veli Deli", CityId = 18 }
            };

            List<SelectListItem> cities = new List<SelectListItem>
            {
                new SelectListItem{Text="Ankara", Value="6"},
                new SelectListItem{Text="Antalya", Value="7"},
                new SelectListItem{Text="İstanbul", Value="34"},
                new SelectListItem{Text="Konya", Value="42"}
            };

            var model = new EmployeeListViewModel
            { 
                Employees = employees,
                Cities = cities
            };

            return View(model);
        }

        public IActionResult Add()
        {
            List<SelectListItem> cities = new List<SelectListItem>
            {
                new SelectListItem{Text="Ankara", Value="6"},
                new SelectListItem{Text="Antalya", Value="7"},
                new SelectListItem{Text="İstanbul", Value="34"},
                new SelectListItem{Text="Konya", Value="42"}
            };

            var model = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = cities
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
    }
}