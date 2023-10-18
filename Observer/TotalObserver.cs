namespace Observer
{
    public class TotalObserver : IObserver
    {
        private decimal total = 0;

        public void Update(Item item)
        {
            total += item.Amount;
            Console.WriteLine($"Total: {total}");
        }
    }
}
