using memento;

Console.WriteLine("*** Memento Design Pattern ***");

Originator originator = new Originator("initial state");
Caretaker caretaker = new Caretaker(originator);

caretaker.ChangeState();
originator.DoSomething();

caretaker.ChangeState();
originator.DoSomething();

caretaker.ChangeState();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();