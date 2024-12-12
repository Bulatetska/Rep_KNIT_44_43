using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager)
    {
        // Створення користувача "admin"
        var user = await userManager.FindByEmailAsync("admin@admin.com");
        if (user == null)
        {
            user = new IdentityUser { UserName = "admin@admin.com", Email = "admin@admin.com" };
            await userManager.CreateAsync(user, "Admin123!");
        }

        // Створення користувача "user"
        var user2 = await userManager.FindByEmailAsync("user@user.com");
        if (user2 == null)
        {
            user2 = new IdentityUser { UserName = "user@user.com", Email = "user@user.com" };
            await userManager.CreateAsync(user2, "User123!");
        }
    }
}
