namespace Observer
{
    public class ListObserver : IObserver
    {
        // Imprime información sobre el nuevo elemento en la lista.
        public void Update(Item item)
        {
            Console.WriteLine($"Elemento agregado: {item.Description}, Cantidad: {item.Amount}");
        }
    }
}
