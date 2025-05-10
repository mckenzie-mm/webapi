using System;

namespace webapi.Models;

public class ProductDTO
{
    public required Guid Id { get; init; } 
    public required string Name { get; init; }
    public required string Category { get; init; }
    public required string SubCategory { get; init; }
}
