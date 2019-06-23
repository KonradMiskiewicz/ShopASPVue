using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Domain.Models
{
    public class Product
    {
        //addnotation for Primary key 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public ICollection<Stock> Stock { get; set; }
    }
}
