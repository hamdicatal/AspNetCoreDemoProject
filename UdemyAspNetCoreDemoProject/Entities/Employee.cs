using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyAspNetCoreDemoProject.Entities
{
    public class Employee
    {
        [Display(Name="ID: ")]
        public int Id { get; set; }
        [Display(Name = "Name: ")]
        public string Name { get; set; }
        [Display(Name = "City: ")]
        public int CityId { get; set; }
    }
}
