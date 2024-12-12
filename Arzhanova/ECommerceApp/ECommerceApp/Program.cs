using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ECommerceApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Налаштування контексту бази даних
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Налаштування Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Додаємо сервіси для контролерів
builder.Services.AddControllersWithViews();  // Якщо ви використовуєте MVC, інакше — AddControllers

var app = builder.Build();

// Створення користувачів при першому запуску
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    await SeedData.Initialize(services, userManager);  // Ініціалізація даних користувачів
}

// Налаштування конвеєра запитів
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Налаштування маршруту для контролерів (для MVC)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Виклик MapControllers, якщо це API
// app.MapControllers();  // Uncomment, якщо використовуєте тільки API

app.Run();
