using Shop.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class UpdateProduct
    {
        private ApplicationDBcontext _context;
        public UpdateProduct(ApplicationDBcontext context)
        {
            _context = context;
        }
        public async Task Update(ProductViewModel mvn)
        {
            await _context.SaveChangesAsync();
        }
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}
