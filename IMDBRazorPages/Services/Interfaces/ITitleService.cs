using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Services.Interfaces
{
    public interface ITitleService
    {
        public IEnumerable<Title> GetTitles();
        public void AddTitle(Title title);
        public void EditTitle(Title title);
        public void DeleteTitle(Title title);
        
    }
}
