using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdemyAspNetCoreDemoProject.Entities;
using UdemyAspNetCoreDemoProject.Models;

namespace UdemyAspNetCoreDemoProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Add()
        {
            var customerAddViewModel = new CustomerAddViewModel
            {
                Customer = new Customer()
            };

            return View(customerAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            return View();
        }
    }
}