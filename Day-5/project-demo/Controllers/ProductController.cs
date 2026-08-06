using Microsoft.AspNetCore.Mvc;
using project_demo.Models;
using project_demo.Repo;

namespace project_demo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repository.GetAllProducts());
    }
}