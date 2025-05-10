using webapi.Models;

namespace webapi.DTO_mappings;

public record ProductResponse(Guid Id, string Name, string Category, string SubCategory)
{
    public static ProductResponse FromModel(Product product)
    {
        return new ProductResponse(product.Id, product.Name, product.Category, product.SubCategory);
    }
}