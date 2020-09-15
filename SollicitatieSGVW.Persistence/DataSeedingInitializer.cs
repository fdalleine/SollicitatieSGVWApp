using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Persistence
{
    public static class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager,
                                                 RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Directie", "Secretariaat" };
            foreach (var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //Admin user
            if (userManager.FindByEmailAsync("frederick.dalleine@sgvw.be").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "frederick.dalleine@sgvw.be",
                    Email = "frederick.dalleine@sgvw.be"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            //Directie user
            if (userManager.FindByEmailAsync("dir@sgvw.be").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "dir@sgvw.be",
                    Email = "dir@sgvw.be"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Directie").Wait();
                }
            }

            //Secretariaat user
            if (userManager.FindByEmailAsync("secr@sgvw.be").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "secr@sgvw.be",
                    Email = "secr@sgvw.be"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Secretariaat").Wait();
                }
            }

            //No Role User
            if (userManager.FindByEmailAsync("user@sgvw.be").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "user@sgvw.be",
                    Email = "user@sgvw.be"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "Password1").Result;
                
            }
        }
    }
}
