using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IMDBRazorPages.Models;

namespace IMDBRazorPages.Data
{
    public class IMDBContext : DbContext
    {
        public IMDBContext (DbContextOptions<IMDBContext> options)
            : base(options)
        {
        }

        public DbSet<IMDBRazorPages.Models.Title> Title { get; set; }

        public DbSet<IMDBRazorPages.Models.Talent> Talent { get; set; }
    }
}
