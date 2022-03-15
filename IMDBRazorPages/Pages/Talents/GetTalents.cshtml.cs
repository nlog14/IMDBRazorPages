using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;
using IMDBRazorPages.Services.Interfaces;

namespace IMDBRazorPages.Pages.Talents
{
    public class GetTalentsModel : PageModel
    {
        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public ITalentService talentService;

        //[BindProperty(SupportsGet = true)]
        public IEnumerable<Talent> Talent { get; set; }

        public GetTalentsModel(IMDBRazorPages.Data.IMDBContext context, ITalentService service)
        {
            _context = context;
            talentService = service;
        }

       // public IList<Talent> Talents { get;set; }

       /* public async Task OnGetAsync()
        {
            Talents = await _context.Talent.ToListAsync();
        }*/


       public void OnGet()
       {
           Talent = talentService.GetTalent();
       }
    }
}
