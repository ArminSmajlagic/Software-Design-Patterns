namespace observer
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserve(IObserver observer);
        void Notify();
    }
}
