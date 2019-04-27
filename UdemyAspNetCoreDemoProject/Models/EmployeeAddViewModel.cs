using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using UdemyAspNetCoreDemoProject.Entities;

namespace UdemyAspNetCoreDemoProject.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}