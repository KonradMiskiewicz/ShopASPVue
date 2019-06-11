using Microsoft.AspNetCore.Mvc;
using Shop.Application.Products;
using Shop.Application.ProductAdmin;
using Shop.Database;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDBcontext _ctx;
        
        public AdminController(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Listing());
        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_ctx).Do(id));
        [HttpPost("products")]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProduct.Request vm) => Ok(await new CreateProduct(_ctx).Add(vm));
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id) => Ok(await new DeleteProduct(_ctx).Delete(id));
        [HttpPut("products")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] UpdateProduct.Request vm) => Ok(await new UpdateProduct(_ctx).Update(vm));
    
    }
}