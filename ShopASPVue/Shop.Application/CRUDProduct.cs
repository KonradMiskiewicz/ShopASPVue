using System;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application
{
    public class CRUDProduct
    {
        private ApplicationDBcontext _context;
        public CRUDProduct(ApplicationDBcontext context)
        {
            _context = context;
        }

        public void Do(int id, string Name, string Description)
        {
            _context.Products.Add(new Product { Id_Product = id, Name = Name, Description = Description });
        }
    }
}
