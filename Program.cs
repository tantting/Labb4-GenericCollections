namespace Labb4_GenericCollections;

class Program
{
    static void Main(string[] args)
    {
        //Create a new object of the Restaurant class
        var restaurant = new Restaurant(); 
        
        //Create four meny items. 
        var menuItem1 = new MenuItem(1, "Carbonara", 119);
        var menuItem2 = new MenuItem(2, "Pasta putanesca", 119);
        var menuItem3 = new MenuItem(3, "Caprese", 99);
        var menuItem4 = new MenuItem(4, "Ceasersallad", 109);
        
        //Add the new menu items to the menu. 
        restaurant.AddtoMenu(menuItem1);
        restaurant.AddtoMenu(menuItem2);
        restaurant.AddtoMenu(menuItem3);
        restaurant.AddtoMenu(menuItem4);
        
        //Printing the meny to the consol. 
        restaurant.ShowMenu();
        
        //Create a list of menuItems that is ordered. 
        List<MenuItem> orderItems1 = new List<MenuItem>()
        {
            restaurant.Menu[0], restaurant.Menu[0], restaurant.Menu[3],
        };
        //Create a new order object of the chosen menu items. 
        Order order1 = new Order(orderItems1, 3);
        //Creata and lof the order
        restaurant.CreateOrder(order1);
        
        //Do the same procedure two more times 
        List<MenuItem> orderItems2 = new List<MenuItem>()
        {
            restaurant.Menu[0], restaurant.Menu[1], restaurant.Menu[1],
        }; 
        Order order2 = new Order(orderItems2, 7);
        restaurant.CreateOrder(order2);
        
        List<MenuItem> orderItems3 = new List<MenuItem>()
        {
            restaurant.Menu[1], restaurant.Menu[2], restaurant.Menu[3],
        };
        Order order3 = new Order(orderItems3, 1); 
        restaurant.CreateOrder(order3);
        
        //Print out all orders in the queue. 
        restaurant.ShowOrders();
        
        //Print out the amount of orders in the queue.
        restaurant.ShowOrderCount();
        
        //Print out the next order in the queue
        restaurant.ShowNextOrder();
        
        //Handle an order
        restaurant.HandleOrder();
        
        //Show the amount of orders i queue. 
        restaurant.ShowOrderCount();
        
        //Add one more order to the queue
        List<MenuItem> orderItems4 = new List<MenuItem>()
        {
            restaurant.Menu[1], restaurant.Menu[2]
        };
        Order order4 = new Order(orderItems3, 1); 
        restaurant.CreateOrder(order4);
        
        //Show the amount of orders i queue. 
        restaurant.ShowOrderCount();
        
        //Handle an order
        restaurant.HandleOrder();
        
        //Handle one more orders
        restaurant.HandleOrder();
        
        //Show the amount of orders i queue. 
        restaurant.ShowOrderCount();
        
        //Print out the next order in the queue
        restaurant.ShowNextOrder();
        
        //Handle an order
        restaurant.HandleOrder();
        
        //Show the amount of orders i queue. 
        restaurant.ShowOrderCount();
        
        
        
        
        
        
        
        
        
        




    }
}