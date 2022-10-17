namespace mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
