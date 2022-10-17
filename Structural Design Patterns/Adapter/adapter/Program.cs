using adaptor;

Console.WriteLine("Adapter design pattern");
Console.WriteLine();

Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);

var result = adapter.GetRequest();

Console.WriteLine(result);