using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductAdmin.GetProducts
{
    public class GetProducts
    {
        private ApplicationDBcontext _ctx;

        public GetProducts(ApplicationDBcontext context)
        {
            _ctx = context;
        }

        public IEnumerable<ProductViewModel> Listing() =>
            _ctx.Products.ToList()
            .Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            });
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }    
}

