using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Class for including many models
/// </summary>
namespace Shop.Application.OrdersAdmin
{
    public class GetOrder
    {
        private ApplicationDBcontext _ctx;

        public GetOrder(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public class Response
        {
            public int OrderID { get; set; }
            public string OrderRef { get; set; }
            public string StripeReference { get; set; }
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress1 { get; set; }
            public string Adress2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
            public IEnumerable<Product> Products { get; set; }
        }
        public class Product
        {
            public string Name { get; set; }
            public string Descritpion { get; set; }
            public int Qty { get; set; }
            public string StockDescription { get; set; }
        }/// <summary>
        /// Method for including methods and returning response from server
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// DBcontext
        /// </returns>
        public Response Do(int id) =>
            _ctx.Orders
            .Where(x => x.OrderID == id)
            .Include(x => x.orderStocks)
            .ThenInclude(x => x.Stock)
            .ThenInclude(x => x.Product)
            .Select(x => new Response
            {
                OrderID = x.OrderID,
                OrderRef = x.OrderRef,
                StripeReference = x.StripeReference,

                First_Name = x.First_Name,
                Last_Name = x.Last_Name,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Adress1 = x.Adress1,
                Adress2 = x.Adress2,
                City = x.City,
                PostCode = x.PostCode,

                Products = x.orderStocks.Select(y => new Product
                {
                    Name = y.Stock.Product.Name,
                    Descritpion = y.Stock.Product.Description,
                    Qty = y.Quality,
                    StockDescription = y.Stock.Description,
                }),
            }).FirstOrDefault();
            
    }
}
