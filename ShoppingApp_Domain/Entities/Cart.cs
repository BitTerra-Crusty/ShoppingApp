using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp_Domain.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<CustomerProduct> CustomerProducts { get; set; }
    }
}
