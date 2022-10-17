namespace factory
{
    public class ConcreteFactory1 : Factory
    {
        public override IObject FactoryMethod()
        {
            return new ConcreteObject1();
        }
    }
}
