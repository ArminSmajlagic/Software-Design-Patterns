using fascade;

Console.WriteLine("*** Fascade Design Pattern ***");

InfrastructureA infraA = new InfrastructureA();
InfrastructureB infraB = new InfrastructureB();

var fascade = new Fascade(infraA, infraB);

Console.WriteLine(fascade.InfrastructureAOperation());
Console.WriteLine(fascade.InfrastructureBOperation());
