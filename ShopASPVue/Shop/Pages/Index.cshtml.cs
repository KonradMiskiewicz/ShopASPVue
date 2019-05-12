using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application;
using Shop.Database;

namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationDBcontext _ctx;
        public IndexModel(ApplicationDBcontext ctx)
        {
             _ctx = ctx;
        }
        [BindProperty]
        public ProductViewModel Product { get; set; }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            await new CRUDProduct(_ctx).Do(Product.Name, Product.Description, Product.Value);
            return RedirectToPage("Index");
        }
    }
}
