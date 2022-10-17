using System;
namespace template_method
{
    public class ConcreteServiceB : AbstractService
    {
        public override void SpecialOperation1()
        {
            Console.WriteLine("ConcreteServiceB says : SpecialOperation1()");
        }

        public override void SpecialOperation2()
        {
            Console.WriteLine("ConcreteServiceB says : SpecialOperation2()");
        }
    }
}
