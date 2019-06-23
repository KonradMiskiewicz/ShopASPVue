using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        ApplicationDBcontext _ctx;
        public CartViewComponent(ApplicationDBcontext ctx)
        {
            _ctx = ctx;
        }
        public IViewComponentResult Invoke(string view = "Default")
        {
            if(view == "Small")
            {
                var totalValue = new GetCart(HttpContext.Session, _ctx).Do().Sum(x => x.RealValue * x.Quality);
                return View(view, $"€ {totalValue}");
            }
            return View(view, new GetCart(HttpContext.Session, _ctx).Do());
        }
    }
}
