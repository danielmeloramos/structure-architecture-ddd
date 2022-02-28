using Moq;
using Moq.Protected;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Integration.Partnership.Tests.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class HttpClientMockExtensions
    {
        public static void MockWithHttpResponseMessage(this Mock<HttpMessageHandler> _fakeHandlerMock, HttpResponseMessage httpResponseMessage)
        {
            _fakeHandlerMock.Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(httpResponseMessage);
        }

        public static void MockWithException(this Mock<HttpMessageHandler> _fakeHandlerMock, Exception exception)
        {
            _fakeHandlerMock.Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .Throws(exception);
        }
    }
}
