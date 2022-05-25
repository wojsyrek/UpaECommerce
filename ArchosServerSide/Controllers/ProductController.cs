using ArchosServerSide.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ArchosServerSide.Controllers
{
    [ApiController]
    [Route("Api/[Controller]/")]
    public class ProductController : Controller
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _product.GetProduts());
        }
    }
}
