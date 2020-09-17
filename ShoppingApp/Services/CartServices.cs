using ShoppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public class CartServices
    {
        public Cart Cart = new Cart();

        public void CreateCartAndAddItemsToCart(int productId, int customerId, int quantity)
        {
            if (Cart.ProductGroups == null)
            {
                CreateCart(customerId);
            }
            var customerProducts = new ProductGroup()
            {
                Id = Cart.ProductGroups.Count() + 1,
                ProductId = productId,
                Quantity = quantity

            };

            Cart.ProductGroups.Add(customerProducts);
        }

        private void CreateCart(int customerId)
        {
            Cart = new Cart();
            Cart.CustomerId = customerId;
            Cart.ProductGroups = new List<ProductGroup>();
        }

        public void IncreaseProductQuantity(int productId)
        {
            Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId).Quantity = Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId).Quantity + 1;
        }

        public void DecreaseProductQuantity(int productId)
        {
            if (Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId).Quantity - 1 == 0)
            {
                Cart.ProductGroups.Remove(Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId));
            }
            else
            {
                Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId).Quantity = Cart.ProductGroups.FirstOrDefault(c => c.ProductId == productId).Quantity - 1;
            }
        }
    }
}
