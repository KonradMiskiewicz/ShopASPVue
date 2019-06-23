using Shop.Database;
using Shop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }
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
