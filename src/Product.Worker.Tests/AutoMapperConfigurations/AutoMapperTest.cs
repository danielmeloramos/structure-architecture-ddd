using NUnit.Framework;
using Product.Worker.Tests.Initializer;
using System.Diagnostics.CodeAnalysis;

namespace Product.Worker.Tests.AutoMapperConfigurations
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    [Category("Worker.AutoMapper")]
    public class AutoMapperTest : TestBase
    {
        [Test]
        public void AutoMapper_DevePossuirUmaConfiguracaoDeMapeamentoValido() => _mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}
