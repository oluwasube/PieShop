using Microsoft.AspNetCore.Mvc;
using Pieshop.Interface;
using PieShop.ViewModels;

namespace Pieshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository; 
        private readonly ICategoryRepository _categoryRepository; 

        public PieController(IPieRepository pieRepository,
        ICategoryRepository categoryRepository )
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult index()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;

            pieListViewModel.CurrentCategory = "Cheese Cake";
            return View( pieListViewModel);
            
        }
    }

   
}