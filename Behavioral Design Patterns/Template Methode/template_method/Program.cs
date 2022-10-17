using template_method;

Console.WriteLine("*** Template method ***");

AbstractService serviceA = new ConcreteServiceA();

serviceA.TemplateMethod();

Console.Write("\n");

AbstractService serviceB = new ConcreteServiceB();

serviceB.TemplateMethod();
