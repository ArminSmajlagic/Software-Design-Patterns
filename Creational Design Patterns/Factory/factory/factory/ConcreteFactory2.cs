namespace factory
{
    public class ConcreteFactory2 : Factory
    {
        public override IObject FactoryMethod()
        {
            return new ConcreteObject2();
        }
    }
}
