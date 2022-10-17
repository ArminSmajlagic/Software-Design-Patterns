namespace template_method
{
    public abstract class AbstractService
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            SpecialOperation1();
            BaseOperation2();
            SpecialOperation2();
        }

        public void BaseOperation1()
        {
            Console.WriteLine("AbstractService doing : BaseOperation1()");
        }

        public void BaseOperation2()
        {
            Console.WriteLine("AbstractService doing : BaseOperation2()");
        }

        public abstract void SpecialOperation1();

        public abstract void SpecialOperation2();
    }
}
