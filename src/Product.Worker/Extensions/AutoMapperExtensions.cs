using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Product.Worker.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var workerModule = typeof(WorkerModule);

            services.AddAutoMapper(workerModule);
        }
    }
}