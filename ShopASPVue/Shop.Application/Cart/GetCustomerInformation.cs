using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
/// <summary>
/// Class for getting customer information 
/// </summary>
namespace Shop.Application.Cart
{
    public class GetCustomerInformation
    {
        private ISession _session;
        public GetCustomerInformation(ISession session)
        {
            _session = session;

        }
        public class Request
        {
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress1 { get; set; }
            public string Adress2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
        }
        /// <summary>
        /// Method generating request to server side from user
        /// </summary>
        /// <returns>
        /// request
        /// </returns>
        public Request Do()
        {
            var stringObject =_session.GetString("customer-onfo");
            if (String.IsNullOrEmpty(stringObject))
            {
                return null;
            }
                
            var customerInformation = JsonConvert.DeserializeObject<CustomerInformation>(stringObject);

            return new Request
            {
                First_Name = customerInformation.First_Name,
                Last_Name = customerInformation.Last_Name,
                Email = customerInformation.Email,
                PhoneNumber = customerInformation.PhoneNumber,
                Adress1 = customerInformation.Adress1,
                Adress2 = customerInformation.Adress2,
                City = customerInformation.City,
                PostCode = customerInformation.PostCode
            };
        }
    }
}
