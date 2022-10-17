using factory;

Console.WriteLine("*** Factory Design Pattern ***");

var object1 = new ConcreteFactory1();

Console.WriteLine("\nThis is "+ object1.GetObject());

var object2 = new ConcreteFactory2();

Console.WriteLine("\nThis is "+ object2.GetObject());

