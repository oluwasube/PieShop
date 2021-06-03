using System.Collections.Generic;
using Pieshop.Models;

namespace Pieshop.Interface
{
    public interface IPieRepository
    {
         IEnumerable<Pie> AllPies{ get; }
         IEnumerable<Pie> PiesOfTheWeek{ get; }
        Pie GetPieById(int PieId);
    }
}