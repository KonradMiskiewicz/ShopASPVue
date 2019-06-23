using System;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.CreateProduct
{
    public class CRUDProduct
    {
        private ApplicationDBcontext _context;
        public CRUDProduct(ApplicationDBcontext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel mvn)
        {
            _context.Products.Add(new Product {
                Name = mvn.Name,
                Description = mvn.Description,
                Value = mvn.Value
               
            });
            await _context.SaveChangesAsync();
        }
    }
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
