using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tech_Review_Site2.Models
{
    public class Tech_Review_Site2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Tech_Review_Site2Context() : base("name=Tech_Review_Site2Context")
        {
        }

        public System.Data.Entity.DbSet<Tech_Review_Site2.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<Tech_Review_Site2.Models.Category> Categories { get; set; }
    }
}
