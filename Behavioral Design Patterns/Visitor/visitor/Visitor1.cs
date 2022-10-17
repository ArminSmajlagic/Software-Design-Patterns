namespace visitor
{
    public class Visitor1 : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            Console.Write("Visitor1 : VisitElementA() -> ");

            element.OperationA();
        }

        public void VisitElementB(ElementB element)
        {
            Console.Write(" Visitor1 : VisitElementB() -> ");

            element.OperationB();
        }
    }
}
