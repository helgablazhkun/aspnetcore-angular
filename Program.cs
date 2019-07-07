using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace aspnetcore_angular
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var defaultBuilder = CreateWebHostBuilder(args);
            //var config = defaultBuilder.Build().Run();

            defaultBuilder.Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
             .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddJsonFile("hosting.json", optional: true);
            })
             .UseStartup<Startup>();
    }
}
