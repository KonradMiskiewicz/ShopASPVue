using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using Shop.Application.Products;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class ProductsController : Controller
    {
        private ApplicationDBcontext _ctx;

        public ProductsController(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Listing());
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id) => Ok(new Application.ProductAdmin.GetProduct(_ctx).Do(id));
        [HttpPost("")]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProduct.Request vm) => Ok(await new CreateProduct(_ctx).Add(vm));
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id) => Ok(await new DeleteProduct(_ctx).Delete(id));
        [HttpPut("")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] UpdateProduct.Request vm) => Ok(await new UpdateProduct(_ctx).Update(vm));
    }
}
