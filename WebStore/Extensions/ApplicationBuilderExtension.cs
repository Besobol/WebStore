using Microsoft.AspNetCore.Identity;
using WebStore.Infrastructure.Data.Models;
using WebStore.Infrastructure.Utilities;

namespace WebStore.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtension
    {
        private static string AdminRoleName = Roles.Admin;
        private static string AdminEmail = "admin@openbook.com";
        private static string AdminTempPass = "Str0ngP@ssword";

        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdminRoleName) == false)
                    {
                        var role = new ApplicationRole { Name = AdminRoleName };

                        await roleManager.CreateAsync(role);
                    }

                    if (await userManager.FindByEmailAsync(AdminEmail) == null)
                    {
                        var hasher = new PasswordHasher<ApplicationUser>();

                        var newUser = new ApplicationUser
                        {
                            UserName = AdminEmail,
                            NormalizedUserName = AdminEmail.ToUpper(),
                            Email = AdminEmail,
                            NormalizedEmail = AdminEmail.ToUpper(),
                        };

                        newUser.PasswordHash = hasher.HashPassword(newUser, AdminTempPass);
                        
                        await userManager.CreateAsync(newUser);
                    }

                    var user = await userManager.FindByEmailAsync(AdminEmail);

                    if (await userManager.IsInRoleAsync(user, AdminRoleName) == false)
                    {
                        await userManager.AddToRoleAsync(user, AdminRoleName);
                    }
                })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
