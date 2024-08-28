using ClothingApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClothingApp.Entities;

namespace ClothingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Dependency Injection of Services
        public IProductService _productservice;

        public ProductsController(IProductService productservice) {
            _productservice = productservice;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products = _productservice.GetAllProductService();
            return Ok(products);
        }

        [HttpPost("insertproduct")]
        public IActionResult InsertProduct(Product product)
        {
            
            return Ok(_productservice.InsertProductService(product));
        }

        [HttpDelete("delete")]

        public IActionResult DeleteProduct(int id)
        {
            return Ok(_productservice.DeleteProductService(id));
        }
    }
}
