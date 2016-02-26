using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Models
{
    public class ModelFactory
    {
        public static Category Create(CategoryViewModel model)
        {
            return new Category
            {
               ID = model.Id,
               Name = model.Name,
            };
        }
    }
}