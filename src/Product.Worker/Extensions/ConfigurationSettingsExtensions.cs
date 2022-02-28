using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Product.Worker.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationSettingsExtensions
    {
        public static void AddSettings(this IServiceCollection services, IConfiguration configuration)
        {

        }
    }
}
