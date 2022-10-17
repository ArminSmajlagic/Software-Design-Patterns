namespace mediator
{
    public class Mediator : IMediator
    {
        private readonly ServiceA serviceA;
        private readonly ServiceB serviceB;

        public Mediator(ServiceA serviceA, ServiceB serviceB)
        {
            this.serviceB = serviceB;
            this.serviceA = serviceA;
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");

                serviceB.OtherOperationB();
            }
            if (ev == "B")
            {
                Console.WriteLine("Mediator reacts on B and triggers following operations:");

                serviceA.OtherOperationA();

            }
        }
    }
}
