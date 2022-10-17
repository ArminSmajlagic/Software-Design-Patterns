namespace factory
{
    public abstract class Factory
    {
        public abstract IObject FactoryMethod();

        public string GetObject()
        {
            var product = FactoryMethod();

            var result = product.ObjectName;

            return result;
        }
    }
}
