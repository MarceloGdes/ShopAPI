using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Shop.Api.Database;
using System.Threading.Tasks;

namespace Shop.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            CreateHost(args);

            var host = CreateHost(args).Seed();
            await host.RunAsync();
        }

        public static IHost CreateHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).Build();
    }
}
