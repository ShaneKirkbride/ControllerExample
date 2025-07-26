using ControllerExample.Components;
using ControllerExample.Data.Weather;

var builder = WebApplication.CreateBuilder(args);

// Razor Components + interactive server-side support
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // Enables SignalR-based interactivity..ahem...

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient());
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAntiforgery(); //fancy security stuff

// Map Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // Server-side SignalR hub..cause SignalR is important...

// API Controllers
app.MapControllers();

app.Run();

public partial class Program { }
