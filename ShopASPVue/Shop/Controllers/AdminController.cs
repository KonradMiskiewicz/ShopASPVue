using Microsoft.AspNetCore.Mvc;
using Shop.Application.Products;
using Shop.Application.ProductAdmin;
using Shop.Database;

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
        public IActionResult CreateProduct([FromBody] CreateProduct.Request vm) => Ok(new CreateProduct(_ctx).Add(vm));
        [HttpDelete("products/{id}")]
        public IActionResult DeleteProduct(int id) => Ok(new DeleteProduct(_ctx).Delete(id));
        [HttpPut("products")]
        public IActionResult UpdateProduct([FromBody] UpdateProduct.ProductViewModel vm) => Ok(new UpdateProduct(_ctx).Update(vm));
    
    }
}