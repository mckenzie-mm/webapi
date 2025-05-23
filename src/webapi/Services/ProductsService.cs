using System;
using webapi.Models;

namespace webapi.Services;

public class ProductsService
{
    private static readonly List<Product> ProductsRepository = [];

    public void Create(Product product)
    {
        // store the product in the database
        ProductsRepository.Add(product);
    }

    public Product? Get(Guid productId)
    {
        // pull the product from the database
        return ProductsRepository.Find(x => x.Id == productId);
    }

    public IEnumerable<Product> Get()
    {
        // return all the products from the database
        return ProductsRepository;
    }
}