using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.UserAdmin
{
    public class CreateUser
    {
        private UserManager<IdentityUser> _user;

        public CreateUser(UserManager<IdentityUser> user)
        {
            _user = user;
        }
        public class Request
        {
            public string UserName { get; set; }
        }
        /// <summary>
        /// Task adding user and adding him role and claim
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        /// true
        /// </returns>
        public async Task<bool> Do(Request request)
        {
            var managerUser = new IdentityUser
            {
                UserName = request.UserName
            };
            await _user.CreateAsync(managerUser, "password");
            var managerClaim = new Claim("Role", "Manager");
            await _user.AddClaimAsync(managerUser, managerClaim);
            return true;
        }
    }
}
