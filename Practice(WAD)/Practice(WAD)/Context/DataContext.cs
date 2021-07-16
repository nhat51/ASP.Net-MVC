using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Practice_WAD_.Models;


namespace Practice_WAD_.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Pratice_WAD")
        {
        }
        public DbSet<Exam> exams { get; set; }
    }
}