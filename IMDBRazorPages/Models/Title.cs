using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBRazorPages.Models
{
    public class Title
    {
        [Key]
        [Required]
        public string title_id { get; set; } //PK
        public int? content_type_id { get; set; } //FK
        [Required]
        public string primary_title { get; set; }
        [Required]
        public string original_title { get; set; }
        public bool? is_adult { get; set; }
        public int? start_year { get; set; }
        public int? end_year { get; set; }
        public int? runtime_minutes { get; set; }

        //Navigation Properties
        //public ICollection<Talent> Talents { get; set; }
    }
}
