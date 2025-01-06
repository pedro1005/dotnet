using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebbApp.Data;
using WebbApp.Models;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<WebbappContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("WebbAppContext")));
}
else
{
    builder.Services.AddDbContext<WebbappContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionWebbAppContext")));
}
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    context.Items["Environment"] = app.Environment.EnvironmentName;
    await next();
});


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
