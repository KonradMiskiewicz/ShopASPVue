using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class for update specific order
/// </summary>
namespace Shop.Application.OrdersAdmin
{
    public class UpdateOrder
    {
        private ApplicationDBcontext _ctx;

        public UpdateOrder(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        /// <summary>
        /// Async task for saving changes in order status
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// awaited Task
        /// </returns>
        public async Task<bool> Do(int id)
        {
            var order = _ctx.Orders.FirstOrDefault(x => x.OrderID == id);
            order.Status = order.Status + 1;
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
