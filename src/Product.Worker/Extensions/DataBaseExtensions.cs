using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Infra.Data.Contexts;
using System.Diagnostics.CodeAnalysis;

namespace Product.Worker.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class DataBaseExtensions
    {
        public static void AddDataBaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductDbContext>(options => options.UseNpgsql("ConnectionString"));
        }
    }
}