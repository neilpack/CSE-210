
using System.Numerics;

class Cart
{
    // vars
    List<Item> _items = new List<Item>();
    
    // methods
    public void Display()
    {
        Console.WriteLine("Items");
        Console.WriteLine("========================");

        foreach (Item item in _items)
        {
            item.Display();
        }
        
        Console.WriteLine("========================");
    }

    public void Add()
    {
        Item newItem = new Item();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        newItem._name = name;
        
        Console.Write("Enter Amount: ");
        string amount = Console.ReadLine();
        newItem._amount = Convert.ToDouble(amount);
        
        _items.Add(newItem);
    }
    
    
    public double CalcTotal()
    {
        double total = 0;

        foreach (Item item in _items)
        {
            total += item._amount;
        }

        return total;
    }
}