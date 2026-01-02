using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; } = new List<Product>();
    public List<CartItem> Cart { get; set; } = new List<CartItem>();

    // Static sample product list
    private static readonly List<Product> SampleProducts = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m },
        new Product { Id = 2, Name = "Mouse", Price = 25.50m },
        new Product { Id = 3, Name = "Keyboard", Price = 49.99m }
    };

    public void OnGet()
    {
        Products = SampleProducts;
        Cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
    }

    public IActionResult OnPostAddToCart(int productId)
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
        var product = SampleProducts.FirstOrDefault(p => p.Id == productId);

        if (product != null)
        {
            // safe access because CartItem.Product is always initialized
            var item = cart.FirstOrDefault(c => c.Product.Id == productId);
            if (item != null)
                item.Quantity++;
            else
                cart.Add(new CartItem { Product = product, Quantity = 1 });
        }

        HttpContext.Session.SetObject("Cart", cart);
        return RedirectToPage();
    }

    public IActionResult OnPostRemoveFromCart(int productId)
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>("Cart") ?? new List<CartItem>();
        var item = cart.FirstOrDefault(c => c.Product.Id == productId);
        if (item != null)
        {
            cart.Remove(item);
            HttpContext.Session.SetObject("Cart", cart);
        }
        return RedirectToPage();
    }
}
