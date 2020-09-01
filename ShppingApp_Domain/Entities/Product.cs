﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShppingApp_Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
