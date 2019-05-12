using System;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application
{
    public class CRUDProduct
    {
        private ApplicationDBcontext _context;
        public CRUDProduct(ApplicationDBcontext context)
        {
            _context = context;
        }

        public async Task Do(string Name, string Description, decimal Value)
        {
            _context.Products.Add(new Product {
                Name = Name,
                Description = Description
            });
            await _context.SaveChangesAsync();
        }
    }
}
