using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Application.Cart
{
    public class AddCustomerInformation
    {
        private ISession _session;
        public AddCustomerInformation(ISession session)
        {
            _session = session;

        }
        public class Request
        {
            [Required]
            public string First_Name { get; set; }
            [Required]
            public string Last_Name { get; set; }
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.PhoneNumber)]
            public string PhoneNumber { get; set; }
            [Required]
            public string Adress1 { get; set; }
            [Required]
            public string Adress2 { get; set; }
            [Required]
            public string City { get; set; }
            [Required]
            public string PostCode { get; set; }
        }
        public void Do(Request request)
        {         
            var stringObject = JsonConvert.SerializeObject(request);

            _session.SetString("customer-info", stringObject);

        }
    }
}
