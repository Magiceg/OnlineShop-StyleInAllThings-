using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SHOP.StyleInAllThings;
using SHOP.StyleInAllThings.Services;
using SHOP.StyleInAllThings.Services.Contracts;

namespace SHOP.StyleInAllThings
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7257/") });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
            

            await builder.Build().RunAsync();
        }
    }
}