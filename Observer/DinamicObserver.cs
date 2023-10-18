namespace Observer
{
    public class DynamicObserver : IObserver
    {
        private int count = 0;

        public void Update(Item item)
        {
            count++;
            Console.WriteLine($"Count: {count}");
        }
    }
}
