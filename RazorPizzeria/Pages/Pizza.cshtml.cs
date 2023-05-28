using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle = "Margerita", PizzaName = "Margerita", Cheese = true, TomatoSauce = true,FinalPrice = 4}
        };

        public void OnGet()
        {
        }
    }
}
