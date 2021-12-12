using Lesson2.SuperShop;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<InMemoryCatalog>();
builder.Services.Configure<JsonOptions>(
    options =>
    {
        options.SerializerOptions.WriteIndented = true;
    }
);


var app = builder.Build();

app.MapGet("/catalog", (InMemoryCatalog catalog) => catalog.GetProducts());

app.Run();