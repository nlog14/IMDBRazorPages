using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Services.Interfaces
{
    public interface ITalentService
    {
        public IEnumerable<Talent> GetTalent();
        public void AddPerson(Talent talent);
        public void EditPerson(Talent talent);
        public void DeletePerson(Talent talent);
    }
}
