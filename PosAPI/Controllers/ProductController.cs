using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApi.Models;
using PosService.Contracts;

namespace PosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await _productService.GetAllProducts();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProducts(Product product)
        {
            if(_productService.AddProduct(product) == null)
            {
                return BadRequest();
            }
            return Ok(_productService.AddProduct(product));
        }
    }
}
