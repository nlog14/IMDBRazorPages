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

namespace IMDBRazorPages.Pages.Titles
{
    public class GetTitlesModel : PageModel
    {
        public ITitleService titleService;
        
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Title> Title { get; set; }

        private readonly IMDBRazorPages.Data.IMDBContext _context;

        public GetTitlesModel(IMDBRazorPages.Data.IMDBContext context, ITitleService service )
        {
            _context = context;
            titleService = service;
        }

       // public IList<Title> Title { get;set; }

      /*  public async Task OnGetAsync()
        {
            
            //await _context.Titles.ToListAsync();
        }*/

        public void OnGet()
        {
            Title = titleService.GetTitles();
        }
    }
}
