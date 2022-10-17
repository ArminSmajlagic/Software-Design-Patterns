using visitor;

Console.WriteLine("*** Visitor design pattern ***");

List<IElement> elements = new List<IElement>
{
    new ElementA(),
    new ElementB()
};

Console.WriteLine("\nThe client code works with all visitors via the base Visitor interface:");
var visitor1 = new Visitor1();

foreach (var element in elements)
{
    element.Accept(visitor1);
}

Console.WriteLine();

Console.WriteLine("It allows the same client code to work with different types of visitors:");
var visitor2 = new Visitor2();

foreach (var element in elements)
{
    element.Accept(visitor2);
}
