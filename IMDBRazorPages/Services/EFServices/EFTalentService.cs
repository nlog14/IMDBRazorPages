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
    public class EFTalentService : ITalentService
    {
        private IMDBContext _context;

        public EFTalentService(IMDBContext service)
        {
            _context = service;
        }
        public void AddPerson(Talent talent)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(Talent talent)
        {
            throw new NotImplementedException();
        }

        public void EditPerson(Talent talent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Talent> GetTalent()
        {
            return _context.Talent.Take(10).ToList();
        }
    }
}
