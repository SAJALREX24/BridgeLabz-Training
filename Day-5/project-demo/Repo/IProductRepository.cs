using project_demo.Models;

namespace project_demo.Repo;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}