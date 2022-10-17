using proxy;

Console.WriteLine("*** Proxy Design Pattern ***");

ISubject subject = new RealSubject();
Proxy proxy = new Proxy(subject);

proxy.Request();

proxy.SetAccess(true);

Console.WriteLine();

proxy.Request();

