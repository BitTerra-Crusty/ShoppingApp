using ShoppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public class ProductServices
    {
        public List<Product> Products;

        public ProductServices()
        {
            LoadProducts();
        }
        public void LoadProducts()
        {
            //category 1
            Product product1 = new Product()
            {
                ProductId = 1,
                CategoryId = 1,
                Description = "Some description cheese",
                PhotoPath = "/images/categories/dairy/cheese.png",
                Name = "Cheese",
                Price = 23.44,
            };
            Product product2 = new Product()
            {
                ProductId = 2,
                CategoryId = 1,
                Description = "Some description of fresh milk",
                PhotoPath = "/images/categories/dairy/milk.jpg",
                Name = "Fresh milk",
                Price = 15.50,
            };
            Product product3 = new Product()
            {
                ProductId = 3,
                CategoryId = 1,
                Description = "Some description of milky yougurt",
                PhotoPath = "/images/categories/dairy/yogurt.png",
                Name = "Yogurt",
                Price = 35.25,
            };

            //category 2
            Product product4 = new Product()
            {
                ProductId = 4,
                CategoryId = 2,
                Description = "Some description of apple",
                PhotoPath = "/images/categories/fruits/apple.png",
                Name = "Apple",
                Price = 5,
            };
            Product product5 = new Product()
            {
                ProductId = 5,
                CategoryId = 2,
                Description = "Some description of banana",
                PhotoPath = "/images/categories/fruits/banana.png",
                Name = "Banana",
                Price = 4.50,
            };
            Product product6 = new Product()
            {
                ProductId = 6,
                CategoryId = 2,
                Description = "Some description tomatoes",
                PhotoPath = "/images/categories/fruits/tomatoes.png",
                Name = "Tomatoe",
                Price = 20,
            };

            //category 3
            Product product7 = new Product()
            {
                ProductId = 7,
                CategoryId = 3,
                Description = "Some description of bread",
                PhotoPath = "/images/categories/grains/bread.png",
                Name = "Bread",
                Price = 16.22,
            };
            Product product8 = new Product()
            {
                ProductId = 8,
                CategoryId = 3,
                Description = "Some description Cereal",
                PhotoPath = "/images/categories/grains/cereal.png",
                Name = "Ceral",
                Price = 32.99,
            };
            Product product9 = new Product()
            {
                ProductId = 9,
                CategoryId = 3,
                Description = "Some description of Pop corns",
                PhotoPath = "/images/categories/grains/popCorn.jpg",
                Name = "Pop Coins",
                Price = 5.44,
            };

            //category 4
            Product product10 = new Product()
            {
                ProductId = 10,
                CategoryId = 4,
                Description = "Some description avocados",
                PhotoPath = "/images/categories/oils/avocados.png",
                Name = "Avocados",
                Price = 3,
            };
            Product product11 = new Product()
            {
                ProductId = 11,
                CategoryId = 4,
                Description = "Some description butter",
                PhotoPath = "/images/categories/oils/butter.png",
                Name = "Butter",
                Price = 22,
            };
            Product product12 = new Product()
            {
                ProductId = 12,
                CategoryId = 4,
                Description = "Some description Olives",
                PhotoPath = "/images/categories/oils/olives.png",
                Name = "Olives",
                Price = 35,
            };

            //category 5
            Product product13 = new Product()
            {
                ProductId = 13,
                CategoryId = 5,
                Description = "Some description of nut",
                PhotoPath = "/images/categories/Proteins/nuts.png",
                Name = "Puts",
                Price = 53.55,
            };
            Product product14 = new Product()
            {
                ProductId = 14,
                CategoryId = 5,
                Description = "Some description of peanut butter",
                PhotoPath = "/images/categories/Proteins/peanut butter.png",
                Name = "Peanut butter",
                Price = 25.50,
            };
            Product product15 = new Product()
            {
                ProductId = 15,
                CategoryId = 5,
                Description = "Some description of split pea",
                PhotoPath = "/images/categories/Proteins/split pea.png",
                Name = "Split pea",
                Price = 15,
            };

            //category 6
            Product product16 = new Product()
            {
                ProductId = 16,
                CategoryId = 6,
                Description = "Some description of carrots",
                PhotoPath = "/images/categories/vegitables/carrots.png",
                Name = "Carrots",
                Price = 13.50,
            };
            Product product17 = new Product()
            {
                ProductId = 17,
                CategoryId = 6,
                Description = "Some description of green beans",
                PhotoPath = "/images/categories/vegitables/green beans.png",
                Name = "Green beans",
                Price = 10,
            };
            Product product18 = new Product()
            {
                ProductId = 18,
                CategoryId = 6,
                Description = "Some description red pepper",
                PhotoPath = "/images/categories/vegitables/red pepper.png",
                Name = "Red pepper",
                Price = 3.50,
            };

            Products = new List<Product>() { product1, product2, product3, product4,  product5, product6, product7, product8, product9, product10, product11, product12, product13, product14, product15, product16, product17, product18 };
        }

        public Product GetProduct(int productId)
        {
            return Products.FirstOrDefault(Product => Product.ProductId == productId);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public void RemoveProduct(int productId)
        {
            Products.Remove(Products.FirstOrDefault(p => p.ProductId == productId));
        }
    }
}
