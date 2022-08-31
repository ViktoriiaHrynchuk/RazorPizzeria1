using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace RazorPizzeria1.Models;

public class PizzaOrder
{
    public int Id { get; set; }
    public string PizzaName { get; set; }
    public  float BasePrice { get; set; }
}