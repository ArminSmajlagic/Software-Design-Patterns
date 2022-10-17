namespace bridge
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "Extended Abstraction operation :" + implementation.OperationImplementation();
        }
    }
}
