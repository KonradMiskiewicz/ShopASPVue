using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.CreateProduct;
using Shop.Application.GetProducts;
using Shop.Database;

namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDBcontext _ctx;
        public IndexModel(ApplicationDBcontext ctx)
        {
             _ctx = ctx;
        }
        [BindProperty]
        public Application.CreateProduct.ProductViewModel Product { get; set; }

        public IEnumerable<Application.GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetProducts(_ctx).Listing();
            
        }
        public async Task<IActionResult> OnPost()
        {
            await new CRUDProduct(_ctx).Do(Product);
            return RedirectToPage("Index");
        }
    }
}
