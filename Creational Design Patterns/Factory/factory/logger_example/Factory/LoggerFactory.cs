using logger_example.ConcreteLogger;
using Microsoft.Extensions.Logging;

namespace logger_example.Factory
{
    public class LoggerFactory : ILoggerFactory
    {
        public IMyLogger CreateLogger<T>()
        {
            IMyLogger logger = null;

            if(typeof(T) == typeof(DummyLogger))
            {
                logger = new DummyLogger();
            }else if(typeof(T) == typeof(TextLogger))
            {
                logger = new TextLogger();
            }
            else if (typeof(T) == typeof(UserLogger))
            {
                logger = new UserLogger();
            }

            return logger;
        }
    }
}
