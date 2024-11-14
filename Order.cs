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

    public void PrintOrder()
    {
        decimal orderSum = 0;
        Console.WriteLine($"\nOrder {_orderId}:");
        foreach (MenuItem order in _orderItems)
        {

            Console.WriteLine($"1 st {order.Name}");
            orderSum = +order.Price;
        } 
        Console.WriteLine($"Summa: {orderSum:C}\n" +
                          $"Till bord nr {_tableNumber}");
    }
}