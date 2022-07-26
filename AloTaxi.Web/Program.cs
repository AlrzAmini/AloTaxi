var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region services

builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run();
