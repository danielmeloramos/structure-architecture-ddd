using NUnit.Framework;
using Product.Functions.Tests.Initializer;
using System.Diagnostics.CodeAnalysis;

namespace Product.Functions.Tests.AutoMapperConfigurations
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    [Category("Functions.AutoMapper")]
    public class AutoMapperTest : TestBase
    {
        [Test]
        public void AutoMapper_DevePossuirUmaConfiguracaoDeMapeamentoValido() => _mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}
