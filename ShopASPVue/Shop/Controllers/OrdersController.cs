using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.OrdersAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Orders controller Policy was on manager because Manager can use Orders operations too
/// I use class from ServiceRegister wchich is static and declared in startup project because of that I avoiding constructor 
/// </summary>
namespace Shop.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class OrdersController : Controller
    {
        /// <summary>
        /// Get orders from applicaiton site
        /// </summary>
        /// <param name="status"></param>
        /// <param name="getOrders"></param>
        /// <returns></returns>
        [HttpGet("")]
        public IActionResult GetOrders(
            int status,
            [FromServices] GetOrders getOrders) =>
            Ok(getOrders.Do(status));
        /// <summary>
        /// Get specific order called from application site
        /// </summary>
        /// <param name="id"></param>
        /// <param name="getOrder"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetOrder(
            int id,
            [FromServices] GetOrder getOrder) =>
            Ok(getOrder.Do(id));
        /// <summary>
        /// Update Specific order status task 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateOrder"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(
            int id,
            [FromServices] UpdateOrder updateOrder) =>
            Ok(await updateOrder.Do(id));
    }
}
