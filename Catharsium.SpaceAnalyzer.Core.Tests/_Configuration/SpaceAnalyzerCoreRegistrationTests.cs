using Catharsium.SpaceAnalyzer.Core._Configuration;
using Catharsium.SpaceAnalyzer.Core.Interfaces;
using Catharsium.SpaceAnalyzer.Core.Logic;
using Catharsium.Util.Testing.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Catharsium.SpaceAnalyzer.Core.Tests._Configuration
{
    [TestClass]
    public class SpaceAnalyzerCoreRegistrationTests
    {
        [TestMethod]
        public void AddSpaceAnalyzerCore_RegistersDependencies()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var config = Substitute.For<IConfiguration>();

            serviceCollection.AddSpaceAnalyzerCore(config);
            serviceCollection.ReceivedRegistration<ISizeCalculator, SizeCalculator>();
        }
    }
}