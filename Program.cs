using CRUDAPPLICATION.BLL.IRepository;
using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.DATABASE;
using CRUDAPPLICATION.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Extra
// Add authentication services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/RegisterationFromCore/Login"; // Adjust as needed
              options.AccessDeniedPath = "/RegisterationFromCore/Login";
     

              options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
              
    });



builder.Services.AddControllersWithViews();

var app = builder.Build();



void ConfigureServices(IServiceCollection services)
{
    services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
    services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(5); // Set session timeout
        options.Cookie.HttpOnly = true; // Make the session cookie HttpOnly
        options.Cookie.IsEssential = true; // Make the session cookie essential for the app
    });
    // Other service configurations
}



void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
          app.UseSession();
          // other middleware
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseHttpsRedirection();// Add extra

app.UseStaticFiles();

app.UseRouting();
//app.UseSession();//Add extra

app.UseAuthentication(); // Add this line
app.UseAuthorization();

//app.UseAuthorization();
//app.UseSession();//Add extra

app.MapControllerRoute(
    name: "default",
        //pattern: "{controller=CONSUMEAPI}/{action=Index}/{id?}");
        pattern: "{controller=RegisterationFromCore}/{action=Login}/{id?}");
          //pattern: "{controller=DisplayImage}/{action=DisplayImage}/{id?}");

app.Run();



