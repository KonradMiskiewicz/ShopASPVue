using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;

namespace Shop.Pages.Checkout
{
    public class PaymentModel : PageModel
    {
        public IActionResult OnGet()
        {
            var information = new GetCustomerInformation(HttpContext.Session);
            if(information == null)
            {
                return RedirectToPage("/Checkout/CustomerCheckInformation");
            }
            return Page();
        }
    }
}