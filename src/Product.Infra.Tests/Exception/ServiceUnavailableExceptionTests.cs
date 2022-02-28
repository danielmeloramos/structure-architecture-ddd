using FluentAssertions;
using NUnit.Framework;
using Product.Infra.Exceptions;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace Product.Infra.Tests.Exception
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    [Category("Infra.Exceptions.Extensions")]
    public class ServiceUnavailableExceptionTests
    {

        [Test]
        public void Test_ServiceUnavailableExceptionShouldCanBeSerializable()
        {
            //Arrange
            var exception = new ServiceUnavailableException(HttpStatusCode.InternalServerError, "teste");
            MemoryStream memstream = new();
            DataContractJsonSerializer serializer = new(typeof(ServiceUnavailableException));

            //Act
            serializer.WriteObject(memstream, exception);
            memstream.Seek(0, SeekOrigin.Begin);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ServiceUnavailableException exceptionSerialized = (ServiceUnavailableException)serializer.ReadObject(memstream);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            //Assert
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            exceptionSerialized.Message.Should().Be(exception.Message);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        [Test]
        public void Test_ServiceUnavailableExceptionShouldHaveServiceUnavailableStringOnMessage()
        {
            //Arrange
            var errormessage = "errormessage";

            //Act
            var exception = new ServiceUnavailableException(errormessage);

            //Assert
            exception.Message.Should().ContainAll("Service Unavailable:", errormessage);

        }

        [Test]
        public void Test_ServiceUnavailableExceptionShouldHaveCtorParameterless()
        {
            //Arrange

            ///Act
            var exception = new ServiceUnavailableException();

            //Assert
            exception.Should().NotBe(null);
        }

    }
}