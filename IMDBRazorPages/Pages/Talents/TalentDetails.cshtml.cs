using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Pages.Talents
{
    public class TalentDetailsModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public TalentDetailsModel(IMDBRazorPages.Data.IMDBContext context)
        {
            _context = context;
        }

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
    }
}
