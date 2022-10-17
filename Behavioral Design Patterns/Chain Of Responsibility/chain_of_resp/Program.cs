using chain_of_resp;

Console.WriteLine("*** Chain of Responsibility Design Pattern ***");

IHandler handlerA = new ConcreteHandlerA();
IHandler handlerB = new ConcreteHandlerB();

Request request1 = new Request("request1");
Request request2 = new Request("request2");

var handle1 = handlerA.Handle(request1);
Console.WriteLine(handle1);

handlerB.SetNext(handlerA);

var handle2 = handlerB.Handle(request2);
Console.WriteLine(handle2);


