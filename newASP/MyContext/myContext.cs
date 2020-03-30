using newASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace newASP.MyContext
{

    public class myContext : DbContext
    {
        public myContext() : base("newASP") { }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Item> Items { get; set; }

    }
}