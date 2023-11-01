using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClownCollegeWD.Models;

namespace ClownCollegeWD.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ClownCollegeWD.Models.Student> Student { get; set; } = default!;
    }
}
