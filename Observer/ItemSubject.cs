using System;

namespace Observer
{
    public class ItemSubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(Item item)
        {
            foreach (var observer in observers)
            {
                observer.Update(item);
            }
        }
    }
}
