using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwindService.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()// : base("name=NorthwindContext")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}