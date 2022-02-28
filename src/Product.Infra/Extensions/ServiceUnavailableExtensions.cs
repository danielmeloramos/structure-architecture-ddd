using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Product.Infra.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ServiceUnavailableExtensions
    {
        public static bool ServiceUnavailable(this Exception exception) => exception is AggregateException ||
                                                                           exception is UriFormatException ||
                                                                           exception is HttpRequestException;
    }
}
