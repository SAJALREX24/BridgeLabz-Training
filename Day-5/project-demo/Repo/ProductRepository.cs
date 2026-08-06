using project_demo.Models;

namespace project_demo.Repo;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1200.00m },
        new Product { Id = 2, Name = "Smartphone", Price = 800.00m }
    };

    public IEnumerable<Product> GetAllProducts() => _products;
}
