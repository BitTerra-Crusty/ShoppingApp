using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp_Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
