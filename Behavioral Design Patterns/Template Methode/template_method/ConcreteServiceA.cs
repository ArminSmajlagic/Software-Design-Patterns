namespace template_method
{
    public class ConcreteServiceA : AbstractService
    {
        public override void SpecialOperation1()
        {
            Console.WriteLine("ConcreteServiceA says : SpecialOperation1()");
        }

        public override void SpecialOperation2()
        {
            Console.WriteLine("ConcreteServiceA says : SpecialOperation2()");
        }
    }
}
