using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Orders
{
    public class CreateOrder
    {
        private ApplicationDBcontext _ctx;

        public CreateOrder(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public class Request
        {
            public string StripeReference { get; set; }
            public string SessionID { get; set; }
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress1 { get; set; }
            public string Adress2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
            public List<Stock> Stocks { get; set; }

        }
        public class Stock
        {
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        public async Task<bool> Do(Request request)
        {
            var stocksOnHold = _ctx.StockOnHold.Where(x => x.SessionID == request.SessionID).ToList();

            _ctx.StockOnHold.RemoveRange(stocksOnHold);

            var order = new Order
            {
                OrderRef = CreateOrderReference(),
                StripeReference = request.StripeReference,
                
                First_Name = request.First_Name,
                Last_Name = request.Last_Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Adress1 = request.Adress1,
                Adress2 = request.Adress2,
                City = request.City,
                PostCode = request.PostCode,
                orderStocks = request.Stocks.Select(x => new OrderStock
                {
                    StockID = x.StockId,
                    Quality = x.Quality
                }).ToList()

            };
            _ctx.Orders.Add(order);
            return await _ctx.SaveChangesAsync() > 0;
        }
        public string CreateOrderReference()
        {
            var chars = "HSDHAHJDKJSANKJSANlkanlkafsnlka99898";
            var result = new char[12];
            var random = new Random();
            do
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = chars[random.Next(chars.Length)];
                }
            } while (_ctx.Orders.Any(x => x.OrderRef == new string(result)));
            return new string(result);
        }
    }
}
