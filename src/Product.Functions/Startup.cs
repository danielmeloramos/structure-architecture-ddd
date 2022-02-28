using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Product.Functions;
using Product.Functions.Extensions;
using System.Diagnostics.CodeAnalysis;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Product.Functions
{
    [ExcludeFromCodeCoverage]
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //Libraries 
            builder.Services.AddAutoMapper();

            //Configuration
            builder.AddSettings();
        }
    }
}