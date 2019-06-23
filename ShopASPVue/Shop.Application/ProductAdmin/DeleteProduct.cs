using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class DeleteProduct
    {
        private ApplicationDBcontext _context;
        public DeleteProduct(ApplicationDBcontext context)
        {
            _context = context;
        }
        /// <summary>
        /// Task is bool type but it has a responsibility for removing specific product from context 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// true
        /// </returns>
        public async Task<bool> Delete(int id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
            return true;
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
