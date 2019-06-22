using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.StockAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class StocksController : Controller
    {
        private ApplicationDBcontext _ctx;

        public StocksController(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("")]
        public IActionResult GetStocks() => Ok(new GetStock(_ctx).ListingStock());
        [HttpPost("")]
        public async Task<IActionResult> CreateStockAsync([FromBody] CreateStock.Request vm) => Ok(await new CreateStock(_ctx).Add(vm));
        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeleteStockAsync(int id) => Ok(await new DeleteStock(_ctx).Delete(id));
        [HttpPut("")]
        public async Task<IActionResult> UpdateStockAsync([FromBody] UpdateStock.Request vm) => Ok(await new UpdateStock(_ctx).Update(vm));
    }
}
