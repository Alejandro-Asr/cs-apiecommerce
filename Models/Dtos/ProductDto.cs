using System;

namespace ApiEcommerce.Models.Dtos;

public class ProductDto
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? ImgUrl { get; set; }
    public string? ImgUrlLocal { get; set; }
    public string SKU { get; set; } = string.Empty;
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdateDate { get; set; } = null;
    // Foreign Key Category
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
}
