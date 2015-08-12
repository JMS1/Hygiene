using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HygieneMVC.Models
{
    public class HygieneContext : DbContext
    {
        public HygieneContext()
            : base("name=HygieneContext")
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<District> Districts { get; set; }

    }
}