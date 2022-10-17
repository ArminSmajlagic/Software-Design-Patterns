namespace strategy
{
    public class Context
    {
        public IStrategy strategy { get; set; }

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
            Console.WriteLine("\nStrategy changed\n");
        }

        public void PrintStrategy()
        {
            Console.WriteLine("\nCurrent strategy is : "+ this.strategy + "\n");
        }

        public void Operation()
        {
            strategy.ExecuteOperation();
        }
    }
}
