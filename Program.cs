// Console template
using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.Clear();
        Card test = new Card("Bryan 2000", 999, 2026, 256, 8, 2.9, 16);

    }
}

class Card
{
    // attributes
    private string name;
    private int price;
    private int year;
    private int rom;
    private int ram;
    private float clock;
    private int colours;
    
    // constructor
    public Card (string n, int p, int y, int r1, int r2, float cl, int c)
    {
        name = n;
        price = p;
        year = y;
        ram = r1;
        rom = r2;
        clock = cl;
        colours = c;

    }

    public void Display()
    {
        Console.WriteLine(name);
        Console.WriteLine($"Price £{price}");
        Console.WriteLine($"Year of launch{year}");
        Console.WriteLine($"RAM (KB): {ram}");
        Console.WriteLine($"ROM (KB): {rom}");
        Console.WriteLine($"Clock (MHz): {clock}");
        Console.WriteLine($"Colours: {colours}");
    }

}