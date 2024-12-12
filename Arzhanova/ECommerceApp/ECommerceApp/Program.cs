using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ECommerceApp.Data;

var builder = WebApplication.CreateBuilder(args);

// ������������ ��������� ���� �����
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ������������ Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// ������ ������ ��� ����������
builder.Services.AddControllersWithViews();  // ���� �� ������������� MVC, ������ � AddControllers

var app = builder.Build();

// ��������� ������������ ��� ������� �������
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    await SeedData.Initialize(services, userManager);  // ����������� ����� ������������
}

// ������������ ������� ������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ������������ �������� ��� ���������� (��� MVC)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ������ MapControllers, ���� �� API
// app.MapControllers();  // Uncomment, ���� ������������� ����� API

app.Run();
