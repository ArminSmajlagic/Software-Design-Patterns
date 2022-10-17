using strategy;

Console.WriteLine("*** Strategy design pattern ***");


IStrategy strategyA = new StrategyA();
Context context = new Context(strategyA);

context.PrintStrategy();

context.Operation();

IStrategy strategyB = new StrategyB();
context.SetStrategy(strategyB);

context.PrintStrategy();

context.Operation();