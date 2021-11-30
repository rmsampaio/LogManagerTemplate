using Microsoft.Extensions.DependencyInjection;

namespace LogManager.Handlers
{
    public static class Logger 
    {
        public static IServiceCollection AddCustonLogger(this IServiceCollection services)
        {
            var logger = LoggerManager.CreateLogger();
            services.AddSingleton(logger);
            return services;
        }
    }
}
