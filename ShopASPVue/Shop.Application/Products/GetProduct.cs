using Microsoft.EntityFrameworkCore;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Products
{
    public class GetProduct
    {
        private ApplicationDBcontext _ctx;

        public GetProduct(ApplicationDBcontext context)
        {
            _ctx = context;
        }

        public ProductViewModel Do(string name) =>
            _ctx.Products.Include(x => x.Stock)
            .Where(x => x.Name == name)
            .Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = $"€ {x.Value.ToString("N2")}",
                Stock = x.Stock.Select(y => new StockViewModel
                {
                    Id = y.Id,
                    Description = y.Description,
                    InStock = y.Quality > 0
                })
            }).FirstOrDefault();
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }
        public class StockViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool InStock { get; set; }
        }
    }
}
