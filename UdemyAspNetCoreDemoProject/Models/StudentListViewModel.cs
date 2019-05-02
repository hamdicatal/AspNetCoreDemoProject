using Microsoft.EntityFrameworkCore;
using UdemyAspNetCoreDemoProject.Entities;

namespace UdemyAspNetCoreDemoProject.Models
{
    public class StudentListViewModel
    {
        public DbSet<Student> Students { get; set; }
    }
}