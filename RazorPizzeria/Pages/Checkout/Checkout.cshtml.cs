using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages.Checkout
{
    //binding all properties to a Model
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {

        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        public void OnGet()
        {

            if (String.IsNullOrWhiteSpace(PizzaName)) {

                PizzaName = "Custom Pizza";
            }

            if (String.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
