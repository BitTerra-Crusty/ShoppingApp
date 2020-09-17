namespace ShoppingApp_Domain.Entities
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}