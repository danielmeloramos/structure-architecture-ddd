using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Product.Functions.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationSettingsExtensions
    {
        public static void AddSettings(this IFunctionsHostBuilder functionsHostBuilder)
        {
            var serviceProvider = functionsHostBuilder.Services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();
            var configBuilder = new ConfigurationBuilder().AddConfiguration(configuration)
                                                          .SetBasePath(Directory.GetCurrentDirectory())
                                                          .AddEnvironmentVariables();
            var config = configBuilder.Build();
        }
    }
}
