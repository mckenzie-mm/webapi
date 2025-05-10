using webapi.Models;

namespace webapi.DTO_mappings;

public record ProductsResponse(IEnumerable<ProductDTO> productsDTO)
{
    public static ProductsResponse FromModels(IEnumerable<Product> products)
    {
        List<ProductDTO> productsDTO = [];

        foreach (Product product in products) 
        {
            ProductDTO productDTO= new ProductDTO {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                SubCategory = product.SubCategory
            };
            productsDTO.Add(productDTO);
        }
        return new ProductsResponse(productsDTO);
    }
}