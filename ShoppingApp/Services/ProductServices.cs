using Microsoft.AspNetCore.Components;
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
        public List<Product> ProductsCopy = new List<Product>();
        public List<Product> FilteredProducts = new List<Product>();
        public List<Product> FilteredProductsCopy = new List<Product>();

        public ProductServices()
        {
            LoadProducts();
            ProductsCopy.AddRange(Products);

        }
        public void LoadProducts()
        {
            //category 1
            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 1,
                Description = "Cheddar: This popular cheese comes in many variations. Its flavor can range from creamy to sharp, and its color can run between a natural white to pumpkin orange.",
                Image = "/images/categories/dairy/cheese.png",
                Name = "Cheese",
                Price = 23.44,
            };
            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 1,
                Description = "Low-fat milk is often confused with reduced-fat milk; however, they are actually different from one another. While the latter"+
                " consists of 2% fat percentage, low-fat milk has only one percent of fat content.",
                Image = "/images/categories/dairy/milk.jpg",
                Name = "Fresh milk",
                Price = 15.50,
            };
            Product product3 = new Product()
            {
                Id = 3,
                CategoryId = 1,
                Description = "Australian yoghurt (fancy, right?) isn't strained like Greek and Icelandic are, so you get a similar texture to traditional yogurt."+
                " But because it is typically made with whole milk, it still has a thicker consistency that's more creamy.",
                Image = "/images/categories/dairy/yogurt.png",
                Name = "Yogurt",
                Price = 35.25,
            };

            //category 2
            Product product4 = new Product()
            {
                Id = 4,
                CategoryId = 2,
                Description = "A lovely red hue with hints of yellow, this species is a hybrid of the Jonathan and the Golden Delicious and bears "+
                "a faint physical resemblance to both. Like the Golden Delicious, Jonagold is sweet and thin-skinned,"+
                " but it takes from the Jonathan a smooth skin and tart flavor. It is versatile and can be used in any recipe that calls for apples.",
                Image = "/images/categories/fruits/apple.png",
                Name = "Apple",
                Price = 5,
            };
            Product product5 = new Product()
            {
                Id = 5,
                CategoryId = 2,
                Description = "“typical” banana found at the local grocery store or farmer’s market. They are slightly sweet and have"+
                " a creamy texture. They have various stages of ripening, from green to yellow, to yellow with brown spots."+
                " They’re grown all across Central America, and their production is essential to the economies in these areas.",
                Image = "/images/categories/fruits/banana.png",
                Name = "Banana",
                Price = 4.50,
            };
            Product product6 = new Product()
            {
                Id = 6,
                CategoryId = 2,
                Description = "like Bonnie Centennial and Super Fantastic, boast robust, slightly more acidic flavors that"+
                " many people find reminiscent of their grandparents’ tomatoes.",
                Image = "/images/categories/fruits/tomatoe.png",
                Name = "Tomatoe",
                Price = 20,
            };

            //category 3
            Product product7 = new Product()
            {
                Id = 7,
                CategoryId = 3,
                Description = "Both banana and zucchini bread are dense, moist, sweet treats, usually chemically leavened with baking soda or powder. "+
                "It’s supposed that both of these “quick” breads got their start in the United States,"+
                " where 18th-century bakers first used pearlash, a refined form of potash, to create carbon dioxide in dough.",
                Image = "/images/categories/grains/bread.png",
                Name = "Bread",
                Price = 16.22,
            };
            Product product8 = new Product()
            {
                Id = 8,
                CategoryId = 3,
                Description = "n imprecise term but nevertheless used to describe cereals that don't use pesticides, artificial fertilizers,"+
                " and no genetically modified ingredients. Their sweeteners are also natural (like honey for instance).",
                Image = "/images/categories/grains/cereal.png",
                Name = "Cereal",
                Price = 32.99,
            };
            Product product9 = new Product()
            {
                Id = 9,
                CategoryId = 3,
                Description = "Also sometimes referred to as “snowflake popcorn”, butterfly is well known for its use in theater-style and"+
                " home-popped popcorn products, usually offered-up with nothing more than a little salt and perhaps some melted butter."+
                " Its relatively delicate shape means butterfly popcorn is best consumed fresh-popped for maximum crunch and freshness.",
                Image = "/images/categories/grains/popCorn.png",
                Name = "Pop Coins",
                Price = 5.44,
            };

            //category 4
            Product product10 = new Product()
            {
                Id = 10,
                CategoryId = 4,
                Description = "The Sharwil is an Australian avocado with a rough, green peel and yellow flesh."+
                " It’s very oily with a bold flavor and is susceptible to frost.",
                Image = "/images/categories/oils/avocados.png",
                Name = "Avocados",
                Price = 3,
            };
            Product product11 = new Product()
            {
                Id = 11,
                CategoryId = 4,
                Description = "Butter is an emulsion made from fat, water, and milk solids. When you heat butter slowly,"+
                " you'll notice that it starts to separate into these three components: white milk solids, foam (which is the water evaporating), "+
                "and bright yellow clarified butter fat. Basically, clarified butter is \"pure\" "+
                "fat without the milk solids or water—it's richer and more shelf-stable than traditional butter.",
                Image = "/images/categories/oils/butter.png",
                Name = "Butter",
                Price = 22,
            };
            Product product12 = new Product()
            {
                Id = 12,
                CategoryId = 4,
                Description = "Green olives are usually picked at the start of the harvest season, in September and October in the northern hemisphere."+
                " They have a firm texture and lovely, nutty flavor."+
                " Black(er) olives are picked in November and December, sometimes as late as January, and they're softer, richer, and meatier.",
                Image = "/images/categories/oils/olives.png",
                Name = "Olives",
                Price = 35,
            };

            //category 5
            Product product13 = new Product()
            {
                Id = 13,
                CategoryId = 5,
                Description = "Rounder, flatter, and sweeter than regular almonds, Marcona almonds are from Spain."+
                " They're usually sold pre-cooked—fried or roasted,"+
                " and salted—and make for great snacks. If you want to cook or bake with them, use them in their raw state.",
                Image = "/images/categories/Proteins/nuts.png",
                Name = "Nuts",
                Price = 53.55,
            };
            Product product14 = new Product()
            {
                Id = 14,
                CategoryId = 5,
                Description = "You can now find many peanut butter options at the store that are made of the basic ingredients"+
                " we associate with peanut butter – ground peanuts and salt."+
                " The natural peanut butter you can now buy in the jar is essentially the same as if you ground up roasted peanuts in a food processor.",
                Image = "/images/categories/Proteins/peanut butter.png",
                Name = "Peanut butter",
                Price = 25.50,
            };
            Product product15 = new Product()
            {
                Id = 15,
                CategoryId = 5,
                Description = "dried and the dull-coloured outer skin of the pea removed, then split in half by hand or by machine at"+
                " the natural split in the seed's cotyledon.",
                Image = "/images/categories/Proteins/split pea.png",
                Name = "Split pea",
                Price = 15,
            };

            //category 6
            Product product16 = new Product()
            {
                Id = 16,
                CategoryId = 6,
                Description = "The ‘Imperator 58’ is large and very flavorful, maxing out at around 9 inches,"+
                " and it is much like the common type that you will find in the store. ",
                Image = "/images/categories/vegitables/carrots.png",
                Name = "Carrots",
                Price = 13.50,
            };
            Product product17 = new Product()
            {
                Id = 17,
                CategoryId = 6,
                Description = "ground, podded green veggies have been fooling you. As a cheap and versatile veggie,"+
                " it never hurt to have a bag of frozen peas on hand. I used them in everything from risotto to soup.",
                Image = "/images/categories/vegitables/green beans.png",
                Name = "Green beans",
                Price = 10,
            };
            Product product18 = new Product()
            {
                Id = 18,
                CategoryId = 6,
                Description = "Relatively large in size, the bell-shaped pepper in its immature state is green with a slightly bitter flavor."+
                " As it matures, it turns bright red and becomes sweeter.",
                Image = "/images/categories/vegitables/red pepper.png",
                Name = "Red pepper",
                Price = 3.50,
            };

            Products = new List<Product>() { product1, product2, product3, product4,  product5, product6, product7, product8, product9, product10, product11, product12, product13, product14, product15, product16, product17, product18 };
        }

        public Product GetProduct(int productId)
        {
            return Products.FirstOrDefault(Product => Product.Id == productId);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
       
        
        
        public void RemoveProduct(int productId)
        {
            Products.Remove(Products.FirstOrDefault(p => p.Id == productId));
        }
    }
}
