using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Session1.Models;
namespace Session1.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Session1")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Session1.Models.Product> Products { get; set; }
    }
}