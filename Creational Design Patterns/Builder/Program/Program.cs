using builder;

Console.WriteLine("Builder Desing pattern");

Console.WriteLine();

var director = new Director();
var builder = new ConcreteBuilder();

director._builder = builder;

director.BuildMinimalObject();

Console.WriteLine("Minimum of product:");
Console.WriteLine(builder.GetObject().GetParts());
Console.WriteLine();

director.BuildFullObject();

Console.WriteLine("Full product:");
Console.WriteLine(builder.GetObject().GetParts());
Console.WriteLine();

builder.BuildPartA();
builder.BuildPartC();

Console.WriteLine("Custom object:");
Console.WriteLine(builder.GetObject().GetParts());