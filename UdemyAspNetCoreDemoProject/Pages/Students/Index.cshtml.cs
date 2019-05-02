using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UdemyAspNetCoreDemoProject.Entities;
using UdemyAspNetCoreDemoProject.Models;

namespace UdemyAspNetCoreDemoProject.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }

        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = _context.students.ToList();
        }

        //ekleme işlemi için;
        [BindProperty] //razor page'da model binding yerine bu attribute kullanılır
        public Student student { get; set; } //cshtml'deki @student için...
        public IActionResult OnPost()
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return RedirectToPage("/students/index");
        }
    }
}