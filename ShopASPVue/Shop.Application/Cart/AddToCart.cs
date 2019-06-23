using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Cart
{
    public class AddToCart
    {
        private ISession _session;
        public AddToCart(ISession session)
        {
            _session = session;

        }
        public class Request
        {
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        public void Do(Request request)
        {
            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            if (!string.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }
            if(cartList.Any(x => x.StockId == request.StockId))
            {
                cartList.Find(x => x.StockId == request.StockId).Qty += request.Quality;
            }
            else
            {
                cartList.Add(new CartProduct
                {
                    StockId = request.StockId,
                    Qty = request.Quality
                });
            }
            stringObject = JsonConvert.SerializeObject(cartList);
            
            //TODO: appending the cart

            _session.SetString("cart", stringObject);

        }
    }
}
