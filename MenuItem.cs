namespace Labb4_GenericCollections;

public class MenuItem
{
    // I denna klass använder vi auto-implemented properties
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public MenuItem(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price:C}";
    }
}