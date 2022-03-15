using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Pages.Talents
{
    public class CreateTalentModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public CreateTalentModel(IMDBRazorPages.Data.IMDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Talent Talent { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Talent.Add(Talent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./GetTalents");
        }
    }
}
