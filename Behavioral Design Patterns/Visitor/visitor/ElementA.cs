namespace visitor
{
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            Console.Write("\nElementA visiting -> ");

            visitor.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine(" ElementA does : OperationA() ");
        }
    }
}
