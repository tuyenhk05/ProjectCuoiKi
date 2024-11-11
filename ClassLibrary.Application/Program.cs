using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Repositorries.Repositorries;
using ClassLibrary.Services.Interfaces;
using ClassLibrary.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Cấu hình Razor Pages và DB Context
        builder.Services.AddRazorPages();
        builder.Services.AddDbContext<QuanliwedContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        // Đăng ký DI
        builder.Services.AddScoped<IKoifishRepositorries, KoifishRepositorries>();
        builder.Services.AddScoped<IKoifish, KoifishServices>();

        // Cấu hình Authentication với Cookie
        builder.Services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth", options =>
        {
            options.Cookie.Name = "MyCookieAuth";
            options.LoginPath = "/Account/Login"; // Trang đăng nhập
        });

        // Tạo ứng dụng từ builder
        var app = builder.Build();

        // Cấu hình middleware và pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        // Cấu hình xác thực và ủy quyền
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}
