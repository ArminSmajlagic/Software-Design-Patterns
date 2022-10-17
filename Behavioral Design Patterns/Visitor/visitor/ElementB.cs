namespace visitor
{
    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            Console.Write("\nElementB visiting -> ");

            visitor.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine(" ElementB does : OperationB() ");
        }
    }
}
