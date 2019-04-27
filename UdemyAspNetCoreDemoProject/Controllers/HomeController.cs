using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdemyAspNetCoreDemoProject.Entities;
using UdemyAspNetCoreDemoProject.Models;

namespace UdemyAspNetCoreDemoProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Customers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{id=1, name="Hamdi Çatal"},
                new Customer{id=2, name="Burak Çatal"},
                new Customer{id=3, name="Yusuf Çatal"}
            };

            List<string> cities = new List<string>
            {
                "Ankara", "İstanbul", "Konya"
            };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                cities = cities
            };

            return View(model);
        }

        // parametre ile filtreleme, query string ile model binding
        public JsonResult CustomerList(string key)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{id=1, name="Hamdi Çatal"},
                new Customer{id=2, name="Burak Çatal"},
                new Customer{id=3, name="Yusuf Çatal"}
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(customers);
            }

            var result = customers.Where(e => e.name.ToLower().Contains(key));

            return Json(result);
        }
    }
}