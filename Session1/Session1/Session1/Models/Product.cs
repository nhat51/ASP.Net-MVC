using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; } //giống BelongTo trong laravel
    }
}