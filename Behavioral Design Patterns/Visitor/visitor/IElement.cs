namespace visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
