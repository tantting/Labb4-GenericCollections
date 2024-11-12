using System.Diagnostics;

namespace Labb4_GenericCollections;

public class Order
{
    // I denna klass använder vi i stället private fields
    static int orderIdCounter = 1;
    private int _orderId;
    private List<MenuItem> _orderItems;
    private int _tableNumber;

    public int OrderId
    {
        get { return _orderId; }
    }
    
    public Order(List<MenuItem> orderItems, int tableNumber)
    {
        // Automatiskt skapande av id
        _orderId = orderIdCounter;
        orderIdCounter++;
        _orderItems = orderItems;
        _tableNumber = tableNumber;
    }
    
    public void AddOrderItems(List<MenuItem> menu)
    {
        bool keepAddingItems = true;
        while (keepAddingItems)
        {
            Console.Write("Ange id på den rätt som ska läggas till order. (När klar, tryck R): ");
            string choice = Console.ReadLine();
            bool inputMenuId = Int32.TryParse(choice, out int itemId); 
            //Lägg till att kolla att id existerar genom att hämta antalet 
            if (inputMenuId && itemId > 0 && itemId < menu.Count)
            {
                _orderItems.Add(menu[itemId-1]);
            }
            else if (choice.ToUpper() == "R")
            {
                keepAddingItems = false; 
            }
            else
            {
                Console.WriteLine("Felaktig input! Försök igen!");
            }
        }
    }

    public void PrintOrder()
    {
        decimal orderSum = 0; 
        Console.WriteLine($"Order {_orderId}");
        foreach (MenuItem order in _orderItems)
        {

            Console.WriteLine($"1 st {order.Name}");
            orderSum = +order.Price;
        } 
        Console.WriteLine($"Summa: {orderSum:C}\n" +
                          $"Till bord nr {_tableNumber}");
    }
}