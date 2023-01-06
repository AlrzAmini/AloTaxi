using Microsoft.AspNetCore.Authentication.Cookies;
using System.Configuration;
using AloTaxi.Data.Context;
using AloTaxi.Data.Repositories;
using AloTaxi.Data.Repositories.User;
using AloTaxi.Domain.Interfaces;
using AloTaxi.Domain.Interfaces.Log;
using AloTaxi.Domain.Interfaces.User;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region services

#region mvc

builder.Services.AddControllersWithViews();

#endregion

#region Authentication

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
});

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Directory.GetCurrentDirectory() + "\\wwwroot\\AuthorizeFile\\"))
    .SetApplicationName("AloTaxi")
    .SetDefaultKeyLifetime(TimeSpan.FromMinutes(43200));

#endregion

#region Context


builder.Services.AddDbContext<AloTaxiDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("AloTaxiDBConnection"));

}, ServiceLifetime.Transient);

#endregion

#region IOC

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IUserGenericRepository<>), typeof(UserGenericRepository<>));
builder.Services.AddScoped<ILoggerRepository,LogRepository>();

#endregion

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
#region pipelines

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

#endregion

app.Run();
