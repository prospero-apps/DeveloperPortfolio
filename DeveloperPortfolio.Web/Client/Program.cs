using DeveloperPortfolio.Web;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using DeveloperPortfolio.Web.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DeveloperPortfolio.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7110/") });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://developerportfolioapi.azurewebsites.net/") });
            
            builder.Services.AddScoped<IProjectService, ProjectService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ITechService, TechService>();

            await builder.Build().RunAsync();
        }
    }
}