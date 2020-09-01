using ShppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShppingApp_Domain.Interfaces
{
    public interface IProduct
    {
        Product CreateProduct(Product product);
        Product GetProduct(int productId);
        void RemoveProduct(int productId);
        List<Product> GetProducts();
    }
}
