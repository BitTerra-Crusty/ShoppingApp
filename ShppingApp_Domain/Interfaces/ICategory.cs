using ShppingApp_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShppingApp_Domain.Interfaces
{
    public interface ICategory
    {
        Category CreateCategory(Category category);
        Category GetCategory(int categoryId);
        List<Category> GetCategories();
        void RemoveCategory(int categoryId);
    }
}
