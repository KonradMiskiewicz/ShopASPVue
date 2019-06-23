using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.StockAdmin
{
    public class CreateStock
    {
        private ApplicationDBcontext _ctx;
        public CreateStock(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Response> Add(Request request)
        {
            var stock = new Stock
            {
                Description = request.Description,
                Quality = request.Quality,
                ProductId = request.ProductId

            };
            _ctx.Stock.Add(stock);
            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = stock.Id,
                Description = stock.Description,
                Quality = stock.Quality
                
            };
        }
        public class Request
        {
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Quality { get; set; }

            
        }
        public class Response
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int Quality { get; set; }

        }
    }
}
