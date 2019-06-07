using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.ProductAdmin;
using Shop.Application.Products;
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
        public CreateProduct.Request Product { get; set; }

        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = new GetProducts(_ctx).Listing();
            
        }
        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Add(Product);
            return RedirectToPage("Index");
        }
    }
}
