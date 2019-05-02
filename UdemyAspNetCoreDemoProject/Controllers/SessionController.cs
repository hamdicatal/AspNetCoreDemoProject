using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyAspNetCoreDemoProject.Entities;
using UdemyAspNetCoreDemoProject.ExtensionMethods;

namespace UdemyAspNetCoreDemoProject.Controllers
{
    public class SessionController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetString("name", "Hamdi ÇATAL");
            HttpContext.Session.SetInt32("age", 25);
            return "Session oluşturuldu!";
        }

        public string GetSession()
        {
            string name = HttpContext.Session.GetString("name");
            int age = Convert.ToInt32(HttpContext.Session.GetInt32("age"));
            return name + " - " + age;
        }

        public string SessionObject()
        {
            HttpContext.Session.SetObject("student", new Student {
                FirstName = "Hamdi",
                LastName = "Çatal",
                Age = 24
            });

            return HttpContext.Session.GetObject<Student>("student").FirstName;
        }
    }
}