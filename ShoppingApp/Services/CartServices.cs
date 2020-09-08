using ShoppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public class CartServices
    {
        public List<Cart> Carts = new List<Cart>();
        public List<CustomerProduct> CustomerProducts = new List<CustomerProduct>();

        public void CreateCart(int productId, int customerId, int quantity)
        {
            CustomerProduct customerProducts = new CustomerProduct()
            {
                CustomerProductId = CustomerProducts.Count() + 1,
                CustumerId = customerId,
                ProductId = productId,
                Quantity = quantity

            };

            CustomerProducts.Add(customerProducts);
        }
        public void IncreaseProductQuantity(int productId, int customerId, int quatity)
        {
            CustomerProducts.FirstOrDefault(c => c.ProductId == productId).Quantity = CustomerProducts.FirstOrDefault(c => c.ProductId == productId).Quantity + 1;
        }
        public void DecreaseProductQuantity(int productId, int customerId, int quatity)
        {
            if (CustomerProducts.FirstOrDefault(c => c.ProductId == productId).Quantity - 1 == 0)
            {
                CustomerProducts.Remove(CustomerProducts.FirstOrDefault(c => c.ProductId == productId));
            }
            else
            {
                CustomerProducts.FirstOrDefault(c => c.ProductId == productId).Quantity = CustomerProducts.FirstOrDefault(c => c.ProductId == productId).Quantity - 1;
            }
        }
        public List<Cart> GetCarts()
        {
            return Carts;
        }
        public void RemoveCart(int cartId)
        {
            Carts.Remove(Carts.FirstOrDefault(Cart => Cart.CartId == cartId));
        }
    }
}
