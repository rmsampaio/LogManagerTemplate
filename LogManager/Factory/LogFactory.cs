using LogManager.Domain;
using Serilog;

namespace LogManager.Factory
{
    public class LogFactory : IFactoryLog
    {
        private readonly ILogger Logger;
        public LogFactory(ILogger logger)
        {
            Logger = logger;
        }

        public void Warning<T>(DataLog<T> dataLog)
        {
            Logger.Warning(dataLog.Message, dataLog.Data);
        }

        public void Information<T>(DataLog<T> dataLog)
        {
            Logger.Information(dataLog.Message, dataLog.Data);
        }

        public void Debug<T>(DataLog<T> dataLog)
        {
            Logger.Debug(dataLog.Message, dataLog.Data);
        }

        public void Error<T>(DataLog<T> dataLog)
        {
            Logger.Error(dataLog.Message, dataLog.Data);
        }

        public ILogger Create()
        {
            var logger = LoggerManager.CreateLogger();
            return logger;
        }
    }
}
