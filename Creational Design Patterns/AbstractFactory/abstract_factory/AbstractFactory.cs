namespace abstract_factory
{
    public interface AbstractFactory
    {
        AbstractObjectA CreateObjectA();
        AbstractObjectB CreateObjectB();
    }
}