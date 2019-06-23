using Microsoft.AspNetCore.Http;
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
    public class GetOrder
    {
        private ISession _session;
        private ApplicationDBcontext _context;
        public GetOrder(ISession session, ApplicationDBcontext context)
        {
            _session = session;
            _context = context;

        }
        public class Response
        {
            public IEnumerable<Product> Products { get; set; }
            public CustomerInformation CustomerInformation { get; set; }
            public int GetTotalCharge() => Products.Sum(x => x.Value * x.Quality);
        }
        public class Product
        {
            public int Value { get; set; }
            public int ProductID { get; set; }
            public int StockId { get; set; }
            public int Quality { get; set; }
        }
        public class CustomerInformation
        {
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress1 { get; set; }
            public string Adress2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
        }
        public Response Do()
        {
            //TODO: account for multiple items in the cart    
            var cart = _session.GetString("cart");

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(cart);
            var listOfProducts = _context.Stock
                .Include(x => x.Product)
                .Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new Product {
                    ProductID = x.ProductId,
                    StockId = x.Id,
                    Value = (int)(x.Product.Value * 100),
                    Quality = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
                }).ToList();

            var customerInfoString = _session.GetString("customer-info");

            var customerInformation = JsonConvert.DeserializeObject<Shop.Domain.Models.CustomerInformation>(customerInfoString);

            return new Response
            {
                Products = listOfProducts,
                CustomerInformation = new CustomerInformation
                {
                    First_Name = customerInformation.First_Name,
                    Last_Name = customerInformation.Last_Name,
                    Email = customerInformation.Email,
                    PhoneNumber = customerInformation.PhoneNumber,
                    Adress1 = customerInformation.Adress1,
                    Adress2 = customerInformation.Adress2,
                    City = customerInformation.City,
                    PostCode = customerInformation.PostCode
                }

            };

        }
    }
}
