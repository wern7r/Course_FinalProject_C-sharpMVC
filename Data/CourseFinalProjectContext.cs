using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseFinalProject.Models;

namespace CourseFinalProject.Data
{
    public class CourseFinalProjectContext : DbContext
    {
        public CourseFinalProjectContext (DbContextOptions<CourseFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CourseFinalProject.Models.Department> Department { get; set; } = default!;
    }
}
