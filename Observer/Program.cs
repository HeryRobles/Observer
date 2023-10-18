using Observer;

var itemsSubject = new ItemSubject();
var listObserver = new ListObserver(); 
var totalObserver = new TotalObserver();
var dynamicObserver = new DynamicObserver();

itemsSubject.Subscribe(listObserver);
itemsSubject.Subscribe(totalObserver);
itemsSubject.Subscribe(dynamicObserver);

Console.WriteLine("Escriba los artículos (descripcion y montos) o escriba salir para salir");

while (true)
{
    string? input = Console.ReadLine();
    if (input == "salir")
        break;

    string[] itemData = input.Split("");
    if (itemData.Length == 2)
    {
        string description = itemData[0];
        decimal amount;
        if (decimal.TryParse(itemData[1], out amount))
        {
            var item = new Item { Description = description, Amount = amount };
            itemsSubject.Notify(item);
        }
    }
}