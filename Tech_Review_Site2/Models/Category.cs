using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tech_Review_Site2.Models
{
    public class Category
    {

        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}