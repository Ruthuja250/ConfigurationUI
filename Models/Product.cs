using System.ComponentModel.DataAnnotations;
using ConfigurationUI.Models;
using ConfigurationUI.Repository;

namespace ConfigurationUI.Models{
public class Product
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ProductCategory  ProductCategory { get; set; }= new ProductCategory();
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImageName { get; set; } = string.Empty;
    
}
}