namespace Observer
{
    public interface IObservable
    {        
        void Subscribe(IObserver Observer);
    }
}