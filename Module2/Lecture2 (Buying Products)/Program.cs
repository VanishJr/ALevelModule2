using System;

namespace Lection1.Version2
{
    internal class Program
    {
        static void Main()
        {
             Item[] items =
        {
            new Item { Name = "Coat", Price = nullable },
            new Item { Name = "Jacket", Price = nullable },
            new Item { Name = "Jeans", Price = nullable },
            new Item { Name = "T-shirt", Price = nullable },
            new Item { Name = "Sweatshirts", Price = nullable },
            new Item { Name = "Cardigans", Price = nullable },
            new Item { Name = "Pants", Price = nullable },
            new Item { Name = "Vests", Price = nullable },
            new Item { Name = "Jacket-shirts", Price = nullable },
            new Item { Name = "Shorts", Price = nullable }
        };

        double sum = 0;
        foreach (Item item in items)
        {
            sum += item.Price;
            Console.WriteLine($"Товар {item.Name} по цене {item.Price}");
        }
        Console.WriteLine($"Общая цена: {sum}");
    }

    private struct Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
        
    }
}