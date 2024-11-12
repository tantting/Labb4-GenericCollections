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

        Console.WriteLine("Vad vill du göra?\n" +
                          "1. Skriva ut menyn\n" +
                          "2. Skapa ny order\n" +
                          "3. Visa aktuella ordrar\n" +
                          "4. Visa analet ordrar i kö\n" +
                          "5. Visa nästa order i kö\n" +
                          "6. Hantera en order\n" +
                          "7. Stänga restaurangen för idag!");

        string choice = Console.ReadLine();

        bool runRestaurant = true;

        while (runRestaurant)
        {
            switch (choice)
            {
                case "1":
                    restaurant.ShowMenu();
                    break; 
                case "2":
                    List<MenuItem> menu = restaurant.Menu; 
                    
                    break; 
                case "3":
                    Console.WriteLine("Visa aktuella ordrar");
                    break; 
                case "4":
                    Console.WriteLine("Visa antalet ordrar i kö");
                    break; 
                case "5":
                    Console.WriteLine("Visa nästa order i kö");
                    break; 
                case "6":
                    Console.WriteLine("Hantera en order");
                    break; 
                case "7":
                    Console.WriteLine("Tack för idag! Bra jobbat!");
                    runRestaurant = false; 
                    break; 
            }
        }
        
        
        
    }
}