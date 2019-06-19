using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Shop.Application.Cart;
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
        public IActionResult OnPost(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();
            var CartOrder = new GetOrder(HttpContext.Session, _ctx).Do();
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
            return RedirectToPage("/Index");
        }
    }
}