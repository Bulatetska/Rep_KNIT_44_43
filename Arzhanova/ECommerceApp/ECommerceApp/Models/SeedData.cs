using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        // Створення ролі "Admin", якщо вона не існує
        var roleExist = await roleManager.RoleExistsAsync("Admin");
        if (!roleExist)
        {
            var role = new IdentityRole("Admin");
            await roleManager.CreateAsync(role);
        }

        // Створення ролі "User", якщо вона не існує
        var userRoleExist = await roleManager.RoleExistsAsync("User");
        if (!userRoleExist)
        {
            var role = new IdentityRole("User");
            await roleManager.CreateAsync(role);
        }

        // Створення користувача "admin"
        var user = await userManager.FindByEmailAsync("admin@admin.com");
        if (user == null)
        {
            user = new IdentityUser { UserName = "admin@admin.com", Email = "admin@admin.com" };
            await userManager.CreateAsync(user, "Admin123!");
        }

        // Призначення ролі "Admin" користувачу "admin"
        if (!await userManager.IsInRoleAsync(user, "Admin"))
        {
            await userManager.AddToRoleAsync(user, "Admin");
        }

        // Створення користувача "user"
        var user2 = await userManager.FindByEmailAsync("user@user.com");
        if (user2 == null)
        {
            user2 = new IdentityUser { UserName = "user@user.com", Email = "user@user.com" };
            await userManager.CreateAsync(user2, "User123!");
        }

        // Призначення ролі "User" користувачу "user"
        if (!await userManager.IsInRoleAsync(user2, "User"))
        {
            await userManager.AddToRoleAsync(user2, "User");
        }
    }
}

