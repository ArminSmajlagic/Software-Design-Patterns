using mediator;

Console.WriteLine("*** Mediator Design Pattern ***");

ServiceA serviceA = new ServiceA();
ServiceB serviceB = new ServiceB();
new Mediator(serviceA, serviceB);


serviceA.OperationA();
serviceB.OperationB();


