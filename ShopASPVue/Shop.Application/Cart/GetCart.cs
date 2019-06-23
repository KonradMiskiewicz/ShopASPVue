using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Class for geting cart
/// </summary>
namespace Shop.Application.Cart
{
    public class GetCart
    {
        private ISession _session;
        private ApplicationDBcontext _context;
        public GetCart(ISession session, ApplicationDBcontext context)
        {
            _session = session;
            _context = context;

        }
        public class Response
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public decimal RealValue { get; set; }
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        /// <summary>
        /// Method for return List of orders created by client 
        /// </summary>
        /// <returns>
        /// List of products and stock id taken by client
        /// </returns>
        public IEnumerable<Response> Do()
        {  
            var stringObject =_session.GetString("cart");
            if (string.IsNullOrEmpty(stringObject))
            {
                return new List<Response>();
            }
            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            var response = _context.Stock
                .Include(x => x.Product)
                .Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new Response
                {
                    Name = x.Product.Name,
                    Value = $"€ {x.Product.Value.ToString("N2")}",
                    RealValue = x.Product.Value,
                    StockId = x.Id,
                    Quality = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
                }).ToList();

                   
            return response;

        }
    }
}
