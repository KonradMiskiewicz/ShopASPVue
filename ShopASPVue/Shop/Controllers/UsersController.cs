using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using System.Threading.Tasks;
using Shop.Application.StockAdmin;
using Shop.Application.Products;
using Microsoft.AspNetCore.Authorization;
using Shop.Application.UserAdmin;

namespace Shop.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class UsersController : Controller
    {
        private CreateUser _createUser;

        public UsersController(CreateUser createUser)
        {
            _createUser = createUser;
        }
        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request)
        {
           await _createUser.Do(request);
            return Ok();
        }
           
    }
}