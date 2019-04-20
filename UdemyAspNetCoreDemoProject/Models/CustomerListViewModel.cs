using System.Collections.Generic;
using UdemyAspNetCoreDemoProject.Entities;

namespace UdemyAspNetCoreDemoProject.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<string> cities { get; set; }
    }
}