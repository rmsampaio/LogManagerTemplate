using LogManager.Domain;
using LogManager.Factory;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

namespace LogManager
{
    public static class LoggerManager
    {
        public static IFactoryLog CreateLogger()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
              .ReadFrom.Configuration(configuration)
              .CreateLogger();

            var factoryLog = new LogFactory(Log.Logger);
            return factoryLog;
        }
    }
}
