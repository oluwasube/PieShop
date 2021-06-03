using System.Collections.Generic;
using Pieshop.Interface;
using Pieshop.Models;

namespace Pieshop.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
        new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Fruitcake", Description = "Blended fruit mix"},
            new Category {CategoryId = 2, CategoryName = "Cheesecake", Description = "cheese made from fineest organic cheese produce"},
            new Category {CategoryId = 3, CategoryName = "Redvelvet", Description = "Best red velvet cake in town"}
        };
    }
}