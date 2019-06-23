using Shop.Database;
using Shop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Class for representing list of all orders
/// </summary>
namespace Shop.Application.OrdersAdmin
{
    public class GetOrders
    {
        private ApplicationDBcontext _ctx;

        public GetOrders(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public class Response
        {
            public int Id { get; set; }
            public string OrderRef { get; set; }
            public string Email { get; set; }
        }/// <summary>
        /// Method for generating list or all orders
        /// </summary>
        /// <param name="status"></param>
        /// <returns>
        /// List
        /// </returns>
        public IEnumerable<Response> Do(int status) =>
            _ctx.Orders
            .Where(x => x.Status == (OrdersStatus)status)
            .Select(x => new Response
            {
                Id = x.OrderID,
                OrderRef = x.OrderRef,
                Email = x.Email
            }).ToList();
        
    }
}
