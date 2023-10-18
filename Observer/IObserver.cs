namespace Observer
{
    // Interfaz que define el método de actualización para los observadores.
    public interface IObserver
    {
        void Update(Item item);
    }
}
