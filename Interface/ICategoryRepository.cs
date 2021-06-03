using System.Collections.Generic;
using Pieshop.Models;

namespace Pieshop.Interface
{
    public interface ICategoryRepository
    {
         IEnumerable<Category> AllCategories{ get; }
    }
}