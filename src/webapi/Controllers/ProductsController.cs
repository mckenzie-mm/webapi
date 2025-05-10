using Microsoft.AspNetCore.Mvc;
using webapi.DTO_mappings;
using webapi.Services;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(ProductsService productsService) : ControllerBase
{
    private readonly ProductsService _productsService = productsService;

    [HttpPost]
    public IActionResult Create(CreateProductRequest request)
    {
        // mapping to internal representation
        var product = request.ToModel();

        // invoking the use case
        _productsService.Create(product);

        // mapping to external representation
        return CreatedAtAction(
            actionName: nameof(Get),
            routeValues: new { ProductId = product.Id },
            value: ProductResponse.FromModel(product));
    }

    [HttpGet("{productId:guid}")]
    public IActionResult Get(Guid productId)
    {
        // invoking the use case
        var product = _productsService.Get(productId);

        // mapping to external representation
        return product is null
            ? Problem(statusCode: StatusCodes.Status404NotFound, detail: $"Product not found (product id: {productId})")
            : Ok(ProductResponse.FromModel(product));
    }

    [HttpGet]
    public IActionResult Get()
    {
       return   Ok("get all products");
    }
}


