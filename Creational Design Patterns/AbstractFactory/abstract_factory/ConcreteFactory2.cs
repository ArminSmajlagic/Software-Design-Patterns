namespace abstract_factory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public AbstractObjectA CreateObjectA()
        {
            return new ConcreteObjectA2();
        }

        public AbstractObjectB CreateObjectB()
        {
            return new ConcreteObjectB2();
        }
    }
}