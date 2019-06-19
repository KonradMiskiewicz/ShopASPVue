using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Database;

namespace Shop.Pages.Checkout
{
    public class CustomerCheckInformationModel : PageModel
    {
        private IHostingEnvironment _env;

        public CustomerCheckInformationModel(IHostingEnvironment env)
        {
            _env = env;
        }
        [BindProperty]
        public AddCustomerInformation.Request CustomerInformation { get; set; }
        public IActionResult OnGet()
        {
            var information = new GetCustomerInformation(HttpContext.Session).Do();
            if(information == null)
            {
                if (_env.IsDevelopment())
                {
                    CustomerInformation = new AddCustomerInformation.Request
                    {
                        First_Name = "A",
                        Last_Name = "A",
                        Email = "A@gmail.com",
                        PhoneNumber = "11",
                        Adress1 = "A",
                        Adress2 = "A",
                        City = "A",
                        PostCode = "A"
                    };
                }
                return Page();
            }
            else
            {
                return RedirectToPage("/Checkout/Payment");
            }
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            new AddCustomerInformation(HttpContext.Session).Do(CustomerInformation);
            return RedirectToPage("/Checkout/Payment");
        }
    }
}