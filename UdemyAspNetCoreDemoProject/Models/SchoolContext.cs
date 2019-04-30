using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAspNetCoreDemoProject.Entities;

namespace UdemyAspNetCoreDemoProject.Models
{
    public class SchoolContext:DbContext
    {
        //ConnectionString bu option'lar ile alınabilir.
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }

        public DbSet<Student> students { get; set; }
    }
}
