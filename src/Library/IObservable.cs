namespace Observer
{
    public interface IObservable
    {        
        void Subscribe(IObserver Observer);
        void Unsubscribe (IObserver Observer);
    }
}