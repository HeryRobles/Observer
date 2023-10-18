namespace Observer
{
    public class TotalObserver : IObserver
    {
        private decimal total = 0;

        public void Update(Item item)
        {
            // Actualiza el total con la cantidad del nuevo elemento.
            total += item.Amount; 
            Console.WriteLine($"Total: {total}");
        }
    }
}
