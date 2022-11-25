using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() 
            {
                ImageTitle="Margarita", 
                PizzaName="Margarita", 
                BasePrice=2,
                Cheese=true,
                TomatoSauce=true,
                FinalPrice=4
            }
        };
        public void OnGet()
        {
        }
    }
}
