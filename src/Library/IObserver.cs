using System.Text;
namespace Observer
{
    public interface IObserver
    {
        void Update(Temperature temperature);
    }
}