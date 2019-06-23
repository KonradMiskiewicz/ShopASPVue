using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Shop.Application.Cart;
using Shop.Application.Orders;
using Shop.Database;
using Stripe;

namespace Shop.Pages.Checkout
{
    public class PaymentModel : PageModel
    {
        public string PublicKey { get; set; }
        private ApplicationDBcontext _ctx;

        public PaymentModel(IConfiguration configuration, ApplicationDBcontext ctx)
        {
            PublicKey = configuration["Stripe:PublicKey"].ToString();
            _ctx = ctx;
        }
        
        public IActionResult OnGet()
        {
            var information = new GetCustomerInformation(HttpContext.Session);
            if(information == null)
            {
                return RedirectToPage("/Checkout/CustomerCheckInformation");
            }
            return Page();
        }
        public async Task<IActionResult> OnPost(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();
            var CartOrder = new Application.Cart.GetOrder(HttpContext.Session, _ctx).Do();
            var customer = customers.Create(new CustomerCreateOptions{
                Email = stripeEmail,
                Source = stripeToken
            });
            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = CartOrder.GetTotalCharge(),
                Description = "Shop Purchase",
                Currency = "eur",
                CustomerId = customer.Id
            });

            //task for generate order
            await new CreateOrder(_ctx).Do(new CreateOrder.Request
            {
                StripeReference = charge.Id,

                First_Name = CartOrder.CustomerInformation.First_Name,
                Last_Name = CartOrder.CustomerInformation.Last_Name,
                Email = CartOrder.CustomerInformation.Email,
                PhoneNumber = CartOrder.CustomerInformation.PhoneNumber,
                Adress1 = CartOrder.CustomerInformation.Adress1,
                Adress2 = CartOrder.CustomerInformation.Adress2,
                City = CartOrder.CustomerInformation.City,
                PostCode = CartOrder.CustomerInformation.PostCode,
                Stocks = CartOrder.Products.Select(x => new CreateOrder.Stock
                {
                    StockId = x.StockId,
                    Quality = x.Quality
                }).ToList()
                
            });
            return RedirectToPage("/Index");
        }
    }
}