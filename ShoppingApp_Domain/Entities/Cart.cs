using System.Collections.Generic;

namespace ShoppingApp_Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public List<ProductGroup> ProductGroups { get; set; }
        public int CustomerId { get; set; }
        public Cart()
        {
            ProductGroups = new List<ProductGroup>();
        }
    }
}
