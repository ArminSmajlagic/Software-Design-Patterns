using prototype;

Person person1 = new Person();

person1.Age = 30;
person1.BirthDate = Convert.ToDateTime("1992-01-02");
person1.Name = "Simon";
person1.Card = new IDCard(1);

Person person2 = person1.ShallowCopy();

Person person3 = person1.DeepCopy();

Console.WriteLine("Person 1 :");
person1.PrintPerson();
Console.WriteLine();

Console.WriteLine("Person 2 :");
person2.PrintPerson();
Console.WriteLine();

Console.WriteLine("Person 3 :");
person3.PrintPerson();
Console.WriteLine();

person1.Card.id = 5;

Console.WriteLine();
Console.WriteLine("After card change :");
Console.WriteLine();


Console.WriteLine("Person 1 :");
person1.PrintPerson();
Console.WriteLine();

Console.WriteLine("Person 2 (card id should change because IDCard is reference type):");
person2.PrintPerson();
Console.WriteLine();

Console.WriteLine("Person 3 :");
person3.PrintPerson();
Console.WriteLine();

