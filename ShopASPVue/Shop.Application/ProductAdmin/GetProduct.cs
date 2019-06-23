using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductAdmin
{
    public class GetProduct
    {
        private ApplicationDBcontext _ctx;

        public GetProduct(ApplicationDBcontext context)
        {
            _ctx = context;
        }
        /// <summary>
        /// Method is for taking spedific product provided by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// ViewModel
        /// </returns>
        public ProductViewModel Do(int id) =>
          _ctx.Products.Where(x => x.Id == id).Select(x => new ProductViewModel
          {
              Id = x.Id,
              Name = x.Name,
              Description = x.Description,
              Value = x.Value
          }).FirstOrDefault();

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}
