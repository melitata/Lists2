using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> coffeeNames = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Lütfen kahve ismi girin: ");
            string coffee = Console.ReadLine();
            coffeeNames.Add(coffee);
        }
        Console.WriteLine("\nKahve İsimleri:");
        foreach (string coffee in coffeeNames)
        {
            Console.WriteLine(coffee);
        }
    }
}
