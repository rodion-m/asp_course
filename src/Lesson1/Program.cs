using System.Globalization;
using System.Runtime.CompilerServices;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

List<string> list = new();
app.MapGet("/a", (HttpContext context) => context.Request.Headers.UserAgent);
app.MapGet("/", (string language) =>
{
    list.Add(DateTime.Now.ToString("F", new CultureInfo(language)));
    return string.Join(", ", list);
});

double Tax(double price)
{
    if (price > 200)
        return ((price - 200) * 0.15);
    else
        return 0;
}

app.MapGet("/customs_duty", (double price) => Tax(price));

app.Run();

