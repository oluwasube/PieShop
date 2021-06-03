using System.Collections.Generic;
using Pieshop.Models;

namespace PieShop.ViewModels
{    
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies{ get; set; }
        public string CurrentCategory{ get; set; }
    }
}