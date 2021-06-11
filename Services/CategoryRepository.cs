using System.Collections.Generic;
using Pieshop.Interface;
using Pieshop.Models;
using PieShop.DataBase;

namespace PieShop.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}