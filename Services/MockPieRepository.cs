using System.Linq;
using System.Collections.Generic;
using Pieshop.Interface;
using Pieshop.Models;

namespace Pieshop.Services
{
    public class MockPieRepository : IPieRepository
    {
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => 
        new List<Pie>
        {
            new Pie {PieId = 1, Name = "Fruitcake pie", Price = 1.5M, ShortDescription = "Blended fruit mix"},
            new Pie {PieId = 2, Name = "CheeseCake pie", Price = 12.5M, ShortDescription = "LOREM IPSUM"},
            new Pie {PieId = 3, Name = "Frenchcake pie", Price = 8.5M, ShortDescription = " fruit mix"},
            new Pie {PieId = 4, Name = "Feutiescake pie", Price = 4.5M, ShortDescription = "Blended fruit mix wazzo milk"},
            
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int PieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == PieId);
        }
    }
}