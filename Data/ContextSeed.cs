using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSocialTour.Enums;
namespace AppSocialTour.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.UsuarioComun.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Historiador.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.Empresa.ToString()));
            await roleManager.CreateAsync(new IdentityRole(IdentityEnums.Roles.SuperAdmin.ToString()));
        }
    }
}