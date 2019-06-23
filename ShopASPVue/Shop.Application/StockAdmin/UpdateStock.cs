using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.StockAdmin
{
    public class UpdateStock
    {
        private ApplicationDBcontext _ctx;
        public UpdateStock(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Response> Update(Request request)
        {
            var stack = new List<Stock>();
            foreach(var stock in request.Stock)
            {
                stack.Add(new Stock
                {
                    Id = stock.Id,
                    Description = stock.Description,
                    Quality = stock.Quality,
                    ProductId = stock.ProductId
                });
            }
            _ctx.Stock.UpdateRange(stack);
            await _ctx.SaveChangesAsync();

            return new Response
            {
               Stock = request.Stock

            };
        }
        public class StockViewModel
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Quality { get; set; }

        }
        public class Request
        {
            public IEnumerable<StockViewModel> Stock { get; set; }

        }
        public class Response
        {
            public IEnumerable<StockViewModel> Stock { get; set; }

        }
    }
}
