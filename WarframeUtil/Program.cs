using System.Configuration;
using System.Text.Unicode;
using Blazor.Analytics;
using BlazorDownloadFile;
using BlazorTable;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using WarframeUtil.Data;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "server=sailehd.de;port=3307;database=WarframeUtil;user=warframe;password=;";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
/*builder.Services.AddSingleton<WeatherForecastService>();*/
builder.Services.AddMudServices();
builder.Services.AddBlazorTable();
builder.Services.AddBlazorDownloadFile(ServiceLifetime.Scoped);
builder.Services.AddScoped<GVState>();
builder.Services.AddSingleton<PereoidicExecutor>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.None)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors(), ServiceLifetime.Singleton);
builder.Services.AddGoogleAnalytics("UA-170984918-1");

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();