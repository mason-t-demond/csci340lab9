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
    public class DetailsModel : PageModel
    {
        private readonly ClownCollegeWD.Data.SchoolContext _context;

        public DetailsModel(ClownCollegeWD.Data.SchoolContext context)
        {
            _context = context;
        }

      public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }
    }
}
