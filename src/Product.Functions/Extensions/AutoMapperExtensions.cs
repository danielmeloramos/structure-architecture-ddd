using Microsoft.Extensions.DependencyInjection;
using Product.Application;
using System.Diagnostics.CodeAnalysis;

namespace Product.Functions.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var startup = typeof(Startup);
            var applicationAppModule = typeof(AppModule);

            services.AddAutoMapper(startup, applicationAppModule);
        }
    }
}
