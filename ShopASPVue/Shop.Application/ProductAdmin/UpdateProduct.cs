﻿using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class UpdateProduct
    {
        private ApplicationDBcontext _context;
        public UpdateProduct(ApplicationDBcontext context)
        {
            _context = context;
        }
        /// <summary>
        /// Method update specific product
        /// </summary>
        /// <param name="mvn"></param>
        /// <returns>
        /// response
        /// </returns>
        public async Task<Response> Update(Request mvn)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == mvn.Id);
            product.Name = mvn.Name;
            product.Description = mvn.Description;
            product.Value = mvn.Value;
            await _context.SaveChangesAsync();

            return new Response{
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Value = product.Value
            };
        }
        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}
