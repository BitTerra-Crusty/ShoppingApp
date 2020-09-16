using ShoppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public class CategoryServices
    {
        public List<Category> Categories;

        public CategoryServices()
        {
            LoadCategories();
        }
        public void LoadCategories()
        {

            //category 1
            Category category1 = new Category()
            {
                categoryId = 4,
                Description = "Oils are high in calories, but are also an important source of nutrients like vitamin E. For adults age 51" +
                " and older, the daily allowance for women is 5 teaspoons of oil and, for men, 6 teaspoons.If possible, " +
                " use oils instead of solid fats.",
                Name = "OILS",
                ImagePath = "/images/categories/oils.png"
            };
            Category category2 = new Category()
            {
                categoryId = 5,
                Description = "Try to include a variety of nutrient-dense proteins in the foods you eat. Choose lean (low-fat) meats and poultry. Keep in mind that you can also get protein from seafood, eggs, beans, and peas, as well as nuts, seeds, and soy products.",
                Name = "PROTEINS",
                ImagePath = "/images/categories/eggs.png"
            };
            Category category3 = new Category()
            {
                categoryId = 1,
                Description = "Most adults do not get enough dairy  in their diet. For your heart health, pick from the many low-fat or fat-free choices in the dairy group. Choosing fat-free or low-fat milk and yogurt, as well as lower-fat cheese, gives you important vitamins and minerals, with less fat.",
                Name = "DAIRY",
                ImagePath = "/images/categories/dairy.png"
            };
            Category category4 = new Category()
            {
                categoryId = 2,
                Description = "Older Americans generally do not eat enough fruit. Yet, there are so many choices—citrus fruits like oranges and grapefruits; different kinds of berries; fruits that grow on trees such as apricots, cherries, peaches, and mangoes; and others like figs, raisins, and pineapples.",
                Name = "FRUITS",
                ImagePath = "/images/categories/tomatoes.png"
            };
            Category category5 = new Category()
            {
                categoryId = 6,
                Description = "Vegetables come in a wide variety of colors,flavors. They’re an important source of vitamins, minerals, and fiber. Dark green vegetables, and kale. Some red and orange vegetables are acorn, sweet potato etc.",
                Name = "VEGITABLES",
                ImagePath = "/images/categories/spinash.png"
            };

            Category category6 = new Category()
            {
                categoryId = 3,
                Description = "Any food made from wheat, rye, rice, oats, cornmeal, barley, or another cereal grain is a grain product. In addition to bread and pasta, breakfast cereal, grits, tortillas, and even popcorn count.",
                Name = "GRAINS",
                ImagePath = "/images/categories/corn.png"
            };

            Categories = new List<Category> { category1, category2, category3, category4, category5, category6 };
        }

        public List<Category> GetCategories()
        {
            return Categories;
        }

        public Category GetCategory(int categoryId)
        {
            return Categories.FirstOrDefault(c => c.categoryId == categoryId);
        }

        public void RemoveCategory(int categoryId)
        {
            Categories.Remove(Categories.FirstOrDefault(c => c.categoryId == categoryId));
        }
    }
}
