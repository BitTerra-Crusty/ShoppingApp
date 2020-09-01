using System;
using System.Collections.Generic;
using System.Text;

namespace ShppingApp_Domain.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CustumerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
