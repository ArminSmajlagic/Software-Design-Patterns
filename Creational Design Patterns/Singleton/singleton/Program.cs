using singleton;

Singleton instance1 = Singleton.GetInstance();
Singleton instance2 = Singleton.GetInstance();

if (instance1 == instance2)
{
    Console.WriteLine("We have same a instance of singleton in both instances.");
}
else
{
    Console.WriteLine("It seems that singlton pattern implementation did not work correctly.");
}