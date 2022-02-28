using NUnit.Framework;
using Product.Application.Tests.Initializer;
using System.Diagnostics.CodeAnalysis;

namespace Product.Application.Tests.AutoMapperConfigurations
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    [Category("Application.AutoMapper")]
    public class AutoMapperTest : TestBase
    {
        [Test]
        public void AutoMapper_DevePossuirUmaConfiguracaoDeMapeamentoValido() => _mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}
