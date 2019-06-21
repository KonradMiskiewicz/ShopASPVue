using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;

using Shop.Database;
using System.Threading.Tasks;
using Shop.Application.StockAdmin;
using Shop.Application.Products;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult GetProduct(int id) => Ok(new Application.ProductAdmin.GetProduct(_ctx).Do(id));
        [HttpPost("products")]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProduct.Request vm) => Ok(await new CreateProduct(_ctx).Add(vm));
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id) => Ok(await new DeleteProduct(_ctx).Delete(id));
        [HttpPut("products")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] UpdateProduct.Request vm) => Ok(await new UpdateProduct(_ctx).Update(vm));

        [HttpGet("stocks")]
        public IActionResult GetStocks() => Ok(new GetStock(_ctx).ListingStock());
        [HttpPost("stocks")]
        public async Task<IActionResult> CreateStockAsync([FromBody] CreateStock.Request vm) => Ok(await new CreateStock(_ctx).Add(vm));
        [HttpDelete("stocks/{id}")]
        public async Task<IActionResult> DeleteStockAsync(int id) => Ok(await new DeleteStock(_ctx).Delete(id));
        [HttpPut("stocks")]
        public async Task<IActionResult> UpdateStockAsync([FromBody] UpdateStock.Request vm) => Ok(await new UpdateStock(_ctx).Update(vm));

    }
}