using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Pages.Talents
{
    public class EditTalentModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public EditTalentModel(IMDBRazorPages.Data.IMDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Talent Talent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Talent = await _context.Talent.FirstOrDefaultAsync(m => m.talent_id == id);

            if (Talent == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Talent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalentExists(Talent.talent_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TalentExists(string id)
        {
            return _context.Talent.Any(e => e.talent_id == id);
        }
    }
}
