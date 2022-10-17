namespace mediator
{
    public class ServiceB : Service
    {
        public ServiceB(IMediator mediator = null)
        {
            SetMediator(mediator);
        }
        public void OperationB(string parameter = "")
        {

            Console.WriteLine("ServiceB operation executed");

            mediator.Notify(this, "B");
        }

        public void OtherOperationB(string parameter = "")
        {

            Console.WriteLine("ServiceB other operation executed");

            mediator.Notify(this, "B");
        }
    }
}
