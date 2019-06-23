using Shop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Domain.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderRef { get; set; }
        public string StripeReference { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public OrdersStatus Status { get; set; }
        public ICollection<OrderStock> orderStocks { get; set; }
    }
}
