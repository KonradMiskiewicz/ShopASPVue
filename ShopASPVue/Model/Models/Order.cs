using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Domain.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderRed { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public ICollection<OrderProduct> orderProducts { get; set; }
    }
}
