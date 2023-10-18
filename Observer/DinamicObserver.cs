namespace Observer
{
    // Incrementa el contador dinámico e imprime su valor
    public class DynamicObserver : IObserver
    {
        private int count = 0;

        public void Update(Item item)
        {
            count++;
            Console.WriteLine($"Contador: {count}");
        }
    }
}
