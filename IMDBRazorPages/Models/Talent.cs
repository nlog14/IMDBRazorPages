using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBRazorPages.Models
{
    public class Talent
    {
        [Key]
        public string talent_id { get; set; } //PK
        [Required]
        public string primary_name { get; set; }
        public int? birth_year { get; set; }
        public int? death_year { get; set; }
    }
}
