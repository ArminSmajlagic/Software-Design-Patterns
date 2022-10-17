using decorator;

Console.WriteLine("*** Decorator Design Pattern ***");

var simple = new Component();

IComponent decoratedComponentA = new ConcreteDecoratorA(simple);
IComponent decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);

Console.WriteLine("\n"+decoratedComponentA.Operation()+"\n");
Console.WriteLine("\n" + decoratedComponentB.Operation()+"\n");
