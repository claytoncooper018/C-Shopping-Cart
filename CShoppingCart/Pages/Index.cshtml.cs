using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace CShoppingCart.Pages;

public class IndexModel : PageModel
{
    public List<CartItem> Cart { get; set; } = new List<CartItem>();

    public void OnGet()
    {
        // Initialize cart if needed
    }

    public void OnPostAdd(string name, double price)
    {
        var existing = Cart.FirstOrDefault(c => c.Name == name);
        if (existing != null)
        {
            existing.Quantity++;
        }
        else
        {
            Cart.Add(new CartItem { Name = name, Price = price, Quantity = 1 });
        }
    }
}

public class CartItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}
