using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Student_web_Application.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddHttpClient<ApiService>();


// Register ApiService
builder.Services.AddHttpClient<ApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5019");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    name: "studentsRoute",
    pattern: "{controller=Home}/{action=Students}/{id?}");

app.MapControllerRoute(
    name: "classesRoute",
    pattern: "{controller=Home}/{action=Classes}/{id?}");

app.MapControllerRoute(
    name: "attendancesRoute",
    pattern: "{controller=Home}/{action=Attendances}/{id?}");

app.Run();
