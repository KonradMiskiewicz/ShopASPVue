using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    public class AddToCart
    {
        private ISession _session;
        private ApplicationDBcontext _ctx;

        public AddToCart(ISession session, ApplicationDBcontext ctx)
        {
            _session = session;
            _ctx = ctx;
        }
        public class Request
        {
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        public async Task<bool> Do(Request request)
        {

            var stockOnHold = _ctx.StockOnHold.Where(x => x.SessionID == _session.Id).ToList();

            var stockToHold = _ctx.Stock.Where(x => x.Id == request.StockId).FirstOrDefault();

            if (stockToHold.Quality < request.Quality)
            {
                return false;
            }

            _ctx.StockOnHold.Add(new StockOnHold
            {
                StockId = stockToHold.Id,
                SessionID = _session.Id,
                Qty = request.Quality,
                ExpiryDate = DateTime.Now.AddMinutes(20)
            });

            stockToHold.Quality = stockToHold.Quality - request.Quality;

            foreach(var stock in stockOnHold)
            {
                stock.ExpiryDate = DateTime.Now.AddMinutes(20);
            }

            await _ctx.SaveChangesAsync();

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

            _session.SetString("cart", stringObject);

            return true;
        }        
    }
}
