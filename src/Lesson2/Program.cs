using Lesson2.Demo.WithDI;
using Microsoft.AspNetCore.Http.Json;
using Shop.Domain.Data;
using Shop.Domain.Providers;
using Shop.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure JSON options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.WriteIndented = true;
});

builder.Services.AddSingleton<IClock, WorldClock>();
builder.Services.AddSingleton<ICatalog, InMemoryCatalog>();
builder.Services.AddSingleton<CatalogService>();


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


app.MapGet("/register", (RegistrationService registrationService) => registrationService.RegisterUser());

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();