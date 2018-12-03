using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorServerSide.App.Services;
using BlazorServerSide.ServiceProxy;
using System.Net.Http;

namespace BlazorServerSide.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Since Blazor is running on the server, we can use an application service
            // to read the forecast data.
            services.AddSingleton<System.String>();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<HttpClient>();
            services.AddScoped<Client, Client>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
