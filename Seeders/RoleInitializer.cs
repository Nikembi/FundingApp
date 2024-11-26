using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using FundingApp.Enums;

public static class RoleInitializer
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        UserRole[] roles = { UserRole.admin, UserRole.creator, UserRole.reguser };

        foreach (var role in roles)
        {
            var roleName = role.ToString();

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole<Guid>(roleName));
            }
        }
    }
}