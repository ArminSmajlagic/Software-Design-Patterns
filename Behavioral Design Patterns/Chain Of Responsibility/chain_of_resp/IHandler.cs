namespace chain_of_resp
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handle(Request request);
    }
}
