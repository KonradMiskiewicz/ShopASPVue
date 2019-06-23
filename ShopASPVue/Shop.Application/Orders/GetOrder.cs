using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Class for taking many params from many models 
/// </summary>
namespace Shop.Application.Orders
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
            public string TotalValue { get; set; }
        }
        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
            public int Quality { get; set; }
            public string StockDescription { get; set; }
        }/// <summary>
        /// Method for creating wires from differend models
        /// </summary>
        /// <param name="reference"></param>
        /// <returns>
        /// DBcontext
        /// </returns>
        public Response Do(string reference)
        {
           return _ctx.Orders
                .Where(x => x.OrderRef == reference)
                .Include(x => x.orderStocks)
                .ThenInclude(x => x.Stock)
                .ThenInclude(x => x.Product)
                .Select(x => new Response
                {
                    OrderRef = x.OrderRef,
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
                        Description = y.Stock.Product.Description,
                        Value = $"€ {y.Stock.Product.Value.ToString("N2")}",
                        Quality = y.Quality,
                        StockDescription = y.Stock.Description
                    }),
                    TotalValue = x.orderStocks.Sum(y => y.Stock.Product.Value).ToString("N2")
                    
                }).FirstOrDefault();
        }
    }
}
