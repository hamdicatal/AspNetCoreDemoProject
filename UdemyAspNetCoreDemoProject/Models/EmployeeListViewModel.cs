using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using UdemyAspNetCoreDemoProject.Entities;

namespace UdemyAspNetCoreDemoProject.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}