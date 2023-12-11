using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClownCollegeWD.Data;
using ClownCollegeWD.Models;

namespace ClownCollegeWD.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ClownCollegeWD.Data.SchoolContext _context;

        public IndexModel(ClownCollegeWD.Data.SchoolContext context)
        {
            _context = context;
        }

       public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Courses != null)
            {
                Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
            }
        }
    }
}
