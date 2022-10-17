using factory;

Console.WriteLine("This is \n");

var product1 = new ConcreteFactory1();

Console.WriteLine(product1.GetObject());


Console.WriteLine("This is \n");

var product2 = new ConcreteFactory2();

Console.WriteLine(product2.GetObject());

