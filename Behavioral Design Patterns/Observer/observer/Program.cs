using observer;

Console.WriteLine("*** Observer design pattern ***");

ISubject subject = new Subject(1);

IObserver observerA = new ObserverA();
IObserver observerB = new ObserverB();

subject.AddObserver(observerA);
subject.AddObserver(observerB);

(subject as Subject).SetState(2);

(subject as Subject).SetState(4);

