using Catharsium.SpaceAnalyzer.Core.Interfaces;
using Catharsium.SpaceAnalyzer.Core.Logic;
using Catharsium.Util.Configuration.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catharsium.SpaceAnalyzer.Core._Configuration
{
    public static class SpaceAnalyzerCoreRegistration
    {
        public static IServiceCollection AddSpaceAnalyzerCore(this IServiceCollection services, IConfiguration config)
        {
            var configuration = config.Load<SpaceAnalyzerCoreConfiguration>();

             services.AddTransient<ISizeCalculator, SizeCalculator>();

            return services;
        }
    }
}