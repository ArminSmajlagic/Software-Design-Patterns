namespace proxy
{
    public class Proxy : ISubject
    {
        private ISubject realSubject;
        private bool allowed = false;
        public Proxy(ISubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                Console.WriteLine("Proxy: Action is allowed");

                realSubject.Request();

                LogAccess();

                return;
            }

            Console.WriteLine("Proxy: Action is not allowed");
        }

        public void SetAccess(bool access) => allowed = access;
        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to executing the request");

            return allowed;
        }

        public void LogAccess()
        {
            Console.WriteLine($"Proxy: Time of request executin -> {DateTime.Now}");
        }
    }
}
