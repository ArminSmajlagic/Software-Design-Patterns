namespace mediator
{
    public class ServiceA : Service
    {
        public ServiceA(IMediator mediator = null)
        {
            SetMediator(mediator);
        }
        public void OperationA(string parameter = "") {

            Console.WriteLine("ServiceA operation executed");

            mediator.Notify(this, "A");
        }

        public void OtherOperationA(string parameter = "")
        {

            Console.WriteLine("ServiceA other operation executed");

            mediator.Notify(this, "A");
        }
    }
}
