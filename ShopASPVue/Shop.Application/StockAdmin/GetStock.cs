using Microsoft.EntityFrameworkCore;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.StockAdmin
{
    public class GetStock
    {
        private ApplicationDBcontext _ctx;
        public GetStock(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ProductViewModel> ListingStock()
        {
            var stock = _ctx.Products.Include(x => x.Stock)
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    Stock = x.Stock
                    .Select(y => new StockViewModel
                    {
                        Id = y.Id,
                        Description = y.Description,
                        Quality = y.Quality
                    })
                }).ToList();
            return stock;
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int Quality { get; set; }

        }
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }

        }
    }
}
