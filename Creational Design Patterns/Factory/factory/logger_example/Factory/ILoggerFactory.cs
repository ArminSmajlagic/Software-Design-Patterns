using logger_example.ConcreteLogger;

namespace logger_example.Factory
{
    public interface ILoggerFactory 
    {
        public IMyLogger CreateLogger<T>();

    }
}