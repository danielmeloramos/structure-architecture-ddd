using AutoMapper;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace Product.Worker.Tests.Initializer
{
    [ExcludeFromCodeCoverage]
    public class TestBase
    {
        protected IMapper _mapper;

        [OneTimeSetUp]
        public void Setup()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    //mc.AddProfile(typeof(MappingProfile));                    
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }
    }
}
