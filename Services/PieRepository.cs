using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pieshop.Interface;
using Pieshop.Models;
using PieShop.DataBase;

namespace PieShop.Services
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
             {
                return _appDbContext.pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek 
         {
            get
             {
                return _appDbContext.pies.Include(c => c.Category);
            }
        }


        public Pie GetPieById(int PieId)
        {
           return _appDbContext.pies.FirstOrDefault(p => p.PieId == PieId);
        }
    }
}