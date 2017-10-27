using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tech_Review_Site2.Models
{
    public class Review
    {

        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Console Name"), MinLength(2), MaxLength(50)]
        public string ConsoleName { get; set; }
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="CPU Speed")]
        public string CpuSpeed { get; set; }
        [Display(Name ="Main Ram")]
        public string MainRam { get; set; }
        [Display(Name ="Additional Memory")]
        public bool HasMemoryOption { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        
    }
}