using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Products
{
    public class GetProducts
    {
        private ApplicationDBcontext _ctx;

        public GetProducts(ApplicationDBcontext context)
        {
            _ctx = context;
        }
        /// <summary>
        /// Method including Stick model in product
        /// </summary>
        /// <returns>
        /// List
        /// </returns>
        public IEnumerable<ProductViewModel> Listing() =>
            _ctx.Products
            .Include(x => x.Stock)
            .Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = $"€ {x.Value.ToString("N2")}",
                StockCount = x.Stock.Sum(y => y.Quality)
            }).ToList();
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
            public int StockCount { get; set; }
        }
    }    
}

