namespace abstract_factory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public AbstractObjectA CreateObjectA()
        {
            return new ConcreteObjectA1();
        }

        public AbstractObjectB CreateObjectB()
        {
            return new ConcreteObjectB1();
        }
    }
}