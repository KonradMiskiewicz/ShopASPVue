using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

/// <summary> 
/// Class for Login system
/// </summary>
namespace Shop.Pages.Accounts
{
    public class LoginModel : PageModel
    {
        private SignInManager<IdentityUser> _signManager;

        public LoginModel (SignInManager<IdentityUser> signManager)
        {
            _signManager = signManager;
        }

        public void OnGet()
        {
        }
        [BindProperty]
        public LoginViewModel Input { get; set; }
        public async Task <IActionResult> OnPost()
        {
            var result = await _signManager.PasswordSignInAsync(Input.UserName, Input.Password, false, true);
           // Console.WriteLine(result);

            if (result.Succeeded)
            {
                return RedirectToPage("/Admin/Index");
            }
            else
            {
                Console.WriteLine(result);
                return Page();
            }
        }
        public class LoginViewModel
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}