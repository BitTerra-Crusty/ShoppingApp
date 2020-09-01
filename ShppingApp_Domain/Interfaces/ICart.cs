using ShppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShppingApp_Domain.Interfaces
{
    public interface ICart
    {
        Cart CreateCart(Cart cart);
        Cart GetCart(int cartId);
        double GetTotalPrice(int productId, int quanitity);
        List<Cart> GetCarts();
        void RemoveCart(int cartId);
    }
}
