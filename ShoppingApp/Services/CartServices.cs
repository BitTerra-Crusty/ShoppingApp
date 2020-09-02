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

        public void CreateCart(int productId, int customerId, int quantity)
        {
            Cart cart = new Cart()
            {
                CartId = Carts.Count() + 1,
                CustumerId = customerId,
                ProductId = productId,
                Quantity = quantity

            };

            Carts.Add(cart);
        }
        public void IncreaseProductQuantity(int productId, int customerId, int quatity)
        {
            Carts.FirstOrDefault(c => c.ProductId == productId).Quantity = Carts.FirstOrDefault(c => c.ProductId == productId).Quantity + 1;
        }
        public void DecreaseProductQuantity(int productId, int customerId, int quatity)
        {
            if (Carts.FirstOrDefault(c => c.ProductId == productId).Quantity - 1 == 0)
            {
                Carts.Remove(Carts.FirstOrDefault(c => c.ProductId == productId));
            }
            else
            {
                Carts.FirstOrDefault(c => c.ProductId == productId).Quantity = Carts.FirstOrDefault(c => c.ProductId == productId).Quantity - 1;
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
