using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> _dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(_dogs);
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) 
        {
            _dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
