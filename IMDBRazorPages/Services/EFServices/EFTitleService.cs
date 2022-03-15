using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDBRazorPages.Data;
using IMDBRazorPages.Models;
using IMDBRazorPages.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IMDBRazorPages.Services.EFServices
{
    public class EFTitleService : ITitleService
    {
        private IMDBContext _context;

        public EFTitleService(IMDBContext service)
        {
            _context = service;
        }
        public void AddTitle(Title title)
        {
            throw new NotImplementedException();
        }

        public void DeleteTitle(Title title)
        {
            throw new NotImplementedException();
        }

        public void EditTitle(Title title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Title> GetTitles()
        {
            return _context.Title.Take(10).ToList();
        }
    }
}
