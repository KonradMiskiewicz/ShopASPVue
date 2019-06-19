using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Models
{
    public class OrderStock
    {

        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Quality { get; set; }
        public int StockID { get; set; }
        public Stock Stock { get; set; }
    }
}
