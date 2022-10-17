namespace bridge
{
    public class Abstraction
    {
        protected IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract operation : " +
                implementation.OperationImplementation();
        }
    }
}
