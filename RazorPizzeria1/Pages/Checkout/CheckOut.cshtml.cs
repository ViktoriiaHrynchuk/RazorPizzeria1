using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria1.DataBase;
using RazorPizzeria1.Models;
namespace RazorPizzeria1.Pages.Check_out
{
    [BindProperties(SupportsGet =true)]
    public class CheckOutModel : PageModel
    {
        public string? PizzaName { get; set; }
        public float PizzasPrice { get; set; }
        public string ImageTitle { get; set; }
        private readonly ApplicationDbContext _context;

        public CheckOutModel (ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzasPrice;
            _context.PIZZA.Add(pizzaOrder);
            _context.SaveChanges();

        }
    }
}
