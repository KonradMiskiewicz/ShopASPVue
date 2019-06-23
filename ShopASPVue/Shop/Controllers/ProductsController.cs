using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using Shop.Application.Products;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Products controller for communication view and methods from application project
/// </summary>
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
        /// <summary>
        /// Get all products and convert to List
        /// </summary>
        /// <returns>
        /// List Of products
        /// </returns>
        [HttpGet("")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Listing());
        /// <summary>
        /// Get specific product from id parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Specific Product
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id) => Ok(new Application.ProductAdmin.GetProduct(_ctx).Do(id));
        /// <summary>
        /// Create product method async 
        /// </summary>
        /// <param name="vm"></param>
        /// <returns>
        /// DBcontext
        /// </returns>
        [HttpPost("")]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProduct.Request vm) => Ok(await new CreateProduct(_ctx).Add(vm));
        /// <summary>
        /// Delete Product taken from id param async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id) => Ok(await new DeleteProduct(_ctx).Delete(id));
        /// <summary>
        /// Update product async
        /// </summary>
        /// <param name="vm"></param>
        /// <returns>
        /// DBcontext
        /// </returns>
        [HttpPut("")]
        public async Task<IActionResult> UpdateProductAsync([FromBody] UpdateProduct.Request vm) => Ok(await new UpdateProduct(_ctx).Update(vm));
    }
}
