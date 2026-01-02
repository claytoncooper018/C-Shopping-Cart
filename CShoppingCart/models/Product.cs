public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;  // initialized to avoid null warnings
    public decimal Price { get; set; }
}
