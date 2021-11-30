using Serilog;

namespace LogManager.Domain
{
    public interface IFactoryLog
    {
        void Warning<T>(DataLog<T> dataLog);
        void Information<T>(DataLog<T> dataLog);
        void Debug<T>(DataLog<T> dataLog);
        void Error<T>(DataLog<T> dataLog);
        ILogger Create();
    }
}
