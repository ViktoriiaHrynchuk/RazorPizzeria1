using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria1.Models;

namespace RazorPizzeria1.Pages.Form
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel? Pizza { get; set; }
        public float PizzasPrice { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            // PizzasPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzasPrice +=2;
            if (Pizza.Cheese) PizzasPrice +=2;
            if (Pizza.Paperoni) PizzasPrice +=6;
            if (Pizza.Mushrooms) PizzasPrice +=3;
            if (Pizza.Tuna) PizzasPrice +=10;
            if (Pizza.Ham) PizzasPrice +=6;
            if (Pizza.PineApple) PizzasPrice += 0;
            if (Pizza.Corn) PizzasPrice +=3;
            if (Pizza.Beef) PizzasPrice +=8;
            if (Pizza.Chicken) PizzasPrice +=8;
            if (Pizza.Olives) PizzasPrice +=5;
            return RedirectToPage("/Checkout/CheckOut", new { Pizza.PizzaName, PizzasPrice});
        }
    }
}
