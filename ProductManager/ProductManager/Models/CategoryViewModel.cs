using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name field is required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }
    }
}