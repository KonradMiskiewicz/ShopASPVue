using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// This is account controller for call the actions
/// </summary>
namespace Shop.Controllers
{
    
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> _signManager;

        public AccountController(SignInManager<IdentityUser> signManager)
        {
            _signManager = signManager;
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();

            return RedirectToPage("/Index");
        }
    }
}
