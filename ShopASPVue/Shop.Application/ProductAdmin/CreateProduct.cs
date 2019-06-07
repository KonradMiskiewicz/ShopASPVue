using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class CreateProduct
    {
        private ApplicationDBcontext _context;
        public CreateProduct(ApplicationDBcontext context)
        {
            _context = context;

        }
        public async Task<Response> Add(Request vn)
        {
            var product = new Product
            {
                Name = vn.Name,
                Description = vn.Description,
                Value = vn.Value

            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return new Response
            {
                Id = product.Id_Product,
                Name = product.Name,
                Description = product.Description,
                Value = product.Value
            };
        }
        public class Request
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}
