namespace Observer
{
    public class ListObserver : IObserver
    {
        public void Update(Item item)
        {
            Console.WriteLine($"Item added: {item.Description}, Amount: {item.Amount}");
        }
    }
}
