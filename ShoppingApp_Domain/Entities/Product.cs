﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp_Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
