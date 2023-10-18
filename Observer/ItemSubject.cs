using System;

namespace Observer
{
    public class ItemSubject
    {
        // Almacena una lista de observadores.
        private List<IObserver> observers = new List<IObserver>();


        // Agrega un observador a la lista de observadores suscritos.
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }


        // Elimina un observador de la lista de observadores suscritos.
        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }


        // Notifica a cada observador sobre el nuevo elemento.
        public void Notify(Item item)
        {
            foreach (var observer in observers)
            {
                observer.Update(item);
            }
        }
    }
}
