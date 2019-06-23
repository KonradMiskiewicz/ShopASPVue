using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Database;

namespace Shop.Pages
{
    
    public class CartModel : PageModel
    {
        private ApplicationDBcontext _context;
        public IEnumerable<GetCart.Response> CartList { get; set; }
        public CartModel(ApplicationDBcontext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            CartList = new GetCart(HttpContext.Session, _context).Do();
            return Page();
        }
    }
}