using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using System.Threading.Tasks;
using Shop.Application.StockAdmin;
using Shop.Application.Products;
using Microsoft.AspNetCore.Authorization;
using Shop.Application.UserAdmin;
/// <summary>
/// Creating users controller for only Admin user
/// </summary>
namespace Shop.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private CreateUser _createUser;

        public UsersController(CreateUser createUser)
        {
            _createUser = createUser;
        }
        /// <summary>
        /// Method for creating users 
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// User
        /// </returns>
        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request)
        {
           await _createUser.Do(request);
            return Ok();
        }
           
    }
}