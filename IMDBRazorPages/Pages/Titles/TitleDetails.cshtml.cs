using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Pages.Titles
{
    public class DetailsModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public DetailsModel(IMDBRazorPages.Data.IMDBContext context)
        {
            _context = context;
        }

        public Title Title { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Title = await _context.Title.FirstOrDefaultAsync(m => m.title_id == id);

            if (Title == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
