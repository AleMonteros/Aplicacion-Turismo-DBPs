using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSocialTour.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.UsuarioComun.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Administrador.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Empresa.ToString()));
        }
    }
}