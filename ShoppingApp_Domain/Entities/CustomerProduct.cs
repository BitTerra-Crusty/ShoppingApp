using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp_Domain.Entities
{
    public class CustomerProduct
    {
        public int CustomerProductId { get; set; }
        public int CustumerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
