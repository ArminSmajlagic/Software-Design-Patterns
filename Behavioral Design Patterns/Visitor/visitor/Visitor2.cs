namespace visitor
{
    public class Visitor2 : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            Console.Write("Visitor2 : VisitElementA() ->");

            element.OperationA();
        }

        public void VisitElementB(ElementB element)
        {
            Console.Write(" Visitor2 : VisitElementB() ->");

            element.OperationB();
        }
    }
}
