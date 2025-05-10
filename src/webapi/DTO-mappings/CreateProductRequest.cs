using webapi.Models;

namespace webapi.DTO_mappings;

public record CreateProductRequest(string Name, string Category, string SubCategory)
{
    public Product ToModel()
    {
        return new Product { Name = Name, Category = Category, SubCategory = SubCategory, };
    }
}
