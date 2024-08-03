using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace identity.Data
{
    public class SeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Admin_123";

        public static async void IdentityTestUser(IApplicationBuilder applicationBuilder)
        {
            var context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            var userManager = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(adminUser);

            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = adminUser,
                    Email = "admin@ofg.com",
                    PhoneNumber = "123456789"
                };

                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
