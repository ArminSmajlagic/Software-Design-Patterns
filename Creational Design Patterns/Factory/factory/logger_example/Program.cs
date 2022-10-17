using logger_example.ConcreteLogger;
using logger_example.Factory;

Console.WriteLine("*** Logger Factory example ***");

ILoggerFactory factory = new LoggerFactory();

var dummyLogger = factory.CreateLogger<DummyLogger>();
var textLogger = factory.CreateLogger<TextLogger>();
var userLogger = factory.CreateLogger<UserLogger>();

dummyLogger.Log();
textLogger.Log();
userLogger.Log();
