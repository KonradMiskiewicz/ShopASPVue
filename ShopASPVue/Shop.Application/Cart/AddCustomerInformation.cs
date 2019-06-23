using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
/// <summary>
/// Class for creating Customer information and serialize to json object
/// </summary>
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
            var customerInformation = new CustomerInformation
            {
                First_Name = request.First_Name,
                Last_Name = request.Last_Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Adress1 = request.Adress1,
                Adress2 = request.Adress2,
                City = request.City,
                PostCode = request.PostCode
            };
            var stringObject = JsonConvert.SerializeObject(customerInformation);
          

            _session.SetString("customer-info", stringObject);

        }
    }
}
