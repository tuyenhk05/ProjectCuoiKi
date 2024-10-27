using ClassLibrary.Repositorries.Entities;
using ClassLibrary.Repositorries.Interfaces;
using ClassLibrary.Repositorries.Repositorries;
using ClassLibrary.Services.Interfaces;
using ClassLibrary.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddDbContext<QuanliwedContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(""));
});
builder.Services.AddScoped<IKoifishRepositorries, KoifishRepositorries>();

builder.Services.AddScoped<IKoifish,KoifishServices>();
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();



