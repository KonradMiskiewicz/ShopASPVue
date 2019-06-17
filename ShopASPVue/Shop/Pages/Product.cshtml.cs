using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Database;
using Shop.Application.Products;
using Microsoft.AspNetCore.Http;
using Shop.Application.Cart;

namespace Shop.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDBcontext _ctx;

        public ProductModel(ApplicationDBcontext context)
        {
            _ctx = context;
        }
        [BindProperty]
        public AddToCart.Request CartViewModel { get; set; }
        public class Test
        {
            public string Id { get; set; }
        }
        public GetProduct.ProductViewModel Product { get; set; }
        public IActionResult OnGet(string name)
        {
            Product = new GetProduct(_ctx).Do(name.Replace("-"," "));
            if(Product == null)
            {
                return Redirect("Index");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            new AddToCart(HttpContext.Session).Do(CartViewModel);
            return RedirectToPage("Cart");
        }
    }
}