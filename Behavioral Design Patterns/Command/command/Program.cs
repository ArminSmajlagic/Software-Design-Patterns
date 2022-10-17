using command;

Console.WriteLine("*** Command design pattern ***");

Receiver receiver = new Receiver();

Invoker invoker = new Invoker();

ICommand command = new ConcreteCommand(receiver);

invoker.SetCommand(command);

Console.WriteLine(command.GetCurrentState());

invoker.InvokeExecution();

Console.WriteLine(command.GetCurrentState());

//Requires refactoring

