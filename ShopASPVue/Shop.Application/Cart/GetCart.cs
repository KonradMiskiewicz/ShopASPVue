﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        public IEnumerable<Response> Do()
        {
            //TODO: account for multiple items in the cart    
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
                    StockId = x.Id,
                    Quality = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
                }).ToList();

                   
            return response;

        }
    }
}
