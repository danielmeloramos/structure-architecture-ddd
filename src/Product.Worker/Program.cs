using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Product.Infra.Data.Contexts;
using Product.Worker.Extensions;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Worker
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        protected Program()
        {
        }

        public static async Task Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                //ConfigurationHostContext
                var configuration = hostContext.Configuration;

                //Libraries 
                services.AddAutoMapper();

                //Settings
                services.AddSettings(configuration);
            })
            .Build();

            Setup(host.Services);

            await host.RunAsync();
        }

        private static void Setup(IServiceProvider services)
        {
            using var scope = services.CreateScope();

            using var context = scope.ServiceProvider.GetService<ProductDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
                context.SaveChanges();
            }
        }
    }
}