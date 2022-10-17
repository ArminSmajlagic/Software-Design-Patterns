namespace fascade
{
    public class Fascade
    {
        protected InfrastructureA infrastructureA;
        protected InfrastructureB infrastructureB;

        public Fascade(InfrastructureA infrastructureA, InfrastructureB infrastructureB)
        {
            this.infrastructureB = infrastructureB ?? throw new ArgumentNullException(nameof(infrastructureB));
            this.infrastructureA = infrastructureA ?? throw new ArgumentNullException(nameof(infrastructureA));
        }

        public string InfrastructureAOperation() => $"\n Infrastructure A Operation :\n     {infrastructureA.Operation1()}\n     {infrastructureA.OperationN()}";
        public string InfrastructureBOperation() => $"\n Infrastructure B Operation :\n     {infrastructureB.Operation1()}\n     {infrastructureB.OperationN()}";
    }
}
