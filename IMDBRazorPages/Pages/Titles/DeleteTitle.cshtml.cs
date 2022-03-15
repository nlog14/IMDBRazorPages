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
    public class DeleteModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public DeleteModel(IMDBRazorPages.Data.IMDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Title = await _context.Title.FindAsync(id);

            if (Title != null)
            {
                _context.Title.Remove(Title);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
