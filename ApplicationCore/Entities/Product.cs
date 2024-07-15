using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Product Name reqiured")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public decimal Price { get; set; }
    public decimal PriceTotal { get; set; } 
    public decimal Discount { get; set; } 
}