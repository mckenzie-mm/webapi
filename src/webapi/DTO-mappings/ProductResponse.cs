using webapi.Models;

namespace webapi.DTO_mappings;

public record ProductResponse(ProductDTO productDTO)
{
    public static ProductResponse FromModel(Product product)
    {
        ProductDTO productDTO= new ProductDTO {
            Id = product.Id,
            Name = product.Name,
            Category = product.Category,
            SubCategory = product.SubCategory
        };
        return new ProductResponse(productDTO);
    }
}