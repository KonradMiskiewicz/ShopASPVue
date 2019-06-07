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

        public IEnumerable<ProductViewModel> Listing() =>
            _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = $"€ {x.Value.ToString("N2")}"
            });
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
        }
    }    
}

