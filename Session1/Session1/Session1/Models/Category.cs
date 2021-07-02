using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Session1.Models
{
    public class Category
    {
        [Key]//khóa chính
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ảnh danh mục ")]
        public string image { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả danh mục ")]
        public string description { get; set; }
        public virtual ICollection<Product> Products { get; set; } //giống HasMany trong laravel
    }
}