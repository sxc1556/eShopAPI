using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models.Request;

public class ProductRequestModel
{
    [Required(ErrorMessage = "Product Name reqiured")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public decimal Price { get; set; }
    public decimal Discount { get; set; } 
}