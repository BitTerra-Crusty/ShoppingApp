using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp_Domain.Entities
{
    public class Category
    {
        public int categoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
