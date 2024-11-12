namespace Labb4_GenericCollections;

public class Restaurant
{
    static List<MenuItem> _menu;
    private Queue<Order> _orders;

    public List<MenuItem> Menu
    {
        get { return _menu; }
    }

    public Restaurant()
    {
        _menu = new List<MenuItem>();
        _orders = new Queue<Order>(); 
    }

    //Lägger till en ny maträtt i menyn och loggar detta till konsolen.
    public void AddtoMenu(MenuItem menuItem)
    {
        _menu.Add(menuItem);
        Console.WriteLine($"{menuItem.Name} har lagts till menyn.");
    }

    //Skriver ut alla maträtter i menyn till konsolen.
    public void ShowMenu()
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Meny:");
        foreach (var menuItem in _menu)
        {
            Console.WriteLine($"{menuItem.Id}. {menuItem}");
        }
        Console.WriteLine("-------------");
    }
    
    //Lägger till en ny beställning i kön och loggar detta till konsolen.
    public void CreateOrder(Order order)
    {
        int index = 0; 
        _orders.Enqueue(order);
        Console.WriteLine($"Beställning nr {order.OrderId} har lagts till.");
    }
    
    //Hanterar (tar bort) den första beställningen i kön och loggar detta till konsolen.
    public void HandleOrder()
    {
        Console.WriteLine("-------------");
        bool testIfOrder = _orders.TryDequeue(out Order order);
        order.PrintOrder();
        //Kör en try.deque istället. 
    }
    
    //Skriver ut alla beställningar i kön till konsolen.
    public void ShowOrders()
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Aktuella beställningar:");
        foreach (Order order in _orders)
        {
            order.PrintOrder();
        }
    }
    
    //Skriver ut beställningen som är näst i kön till konsolen.
    public void ShowNextOrder()
    {
        Console.WriteLine("-------------");
        Console.Write("Näst på tur är ");
        _orders.Peek().PrintOrder();
    }
    
    //Skriver ut antalet beställningar i kön till konsolen.
    public void ShowOrderCount()
    {
        Console.WriteLine("-------------");
        Console.WriteLine($"Antal beställningar i kö är just nu {_orders.Count}");   
    }



}