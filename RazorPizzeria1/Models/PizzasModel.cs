namespace RazorPizzeria1.Models;

public class PizzasModel
{
    public string ImageTitle { get; set; }
    public string PizzaName { get; set; }
    public float BasePrice { get; set; } = 2;
    public bool TomatoSauce { get; set; }
    public bool Cheese { get; set; }
    public bool Paperoni { get; set; }
    public bool Mushrooms { get; set; }
    public bool Tuna { get; set; }
    public bool Ham { get; set; }
    public bool PineApple { get; set; }
    public bool Corn { get; set; }
    public bool Beef { get; set; }
    public bool Chicken { get; set; }
    public bool Olives { get; set; }
    public float FinalePrice { get; set; }
}