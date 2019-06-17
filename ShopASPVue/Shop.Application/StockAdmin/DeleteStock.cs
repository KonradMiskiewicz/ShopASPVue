using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.StockAdmin
{
    public class DeleteStock
    {
        private ApplicationDBcontext _context;
        public DeleteStock(ApplicationDBcontext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(int id)
        {
            var Stock = _context.Stock.FirstOrDefault(x => x.Id == id);
            _context.Stock.Remove(Stock);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
