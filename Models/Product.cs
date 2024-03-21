namespace WebHelloWorld.Models;
public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public Categories? Category { get; set; } // Add this property
}