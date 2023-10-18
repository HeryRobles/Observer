using Observer;

var itemsSubject = new ItemSubject(); // Crea un objeto sujeto que llevará el seguimiento de los observadores.
var listObserver = new ListObserver(); // Crea un observador para la lista de elementos.
var totalObserver = new TotalObserver(); // Crea un observador para el cálculo del total.
var dynamicObserver = new DynamicObserver(); // Crea un observador para llevar un contador dinámico.

itemsSubject.Subscribe(listObserver); // Suscribe el observador de la lista al sujeto.
itemsSubject.Subscribe(totalObserver); // Suscribe el observador del total al sujeto.
itemsSubject.Subscribe(dynamicObserver); // Suscribe el observador dinámico al sujeto.

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
            var item = new Item { Description = description, Amount = amount }; // Crea un nuevo elemento.
            itemsSubject.Notify(item); // Notifica a los observadores sobre el nuevo elemento.
        }
    }
}