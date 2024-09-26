using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<string> items = new List<string>();
        string user_input = "";
        while (user_input != "q")
        {
            Console.WriteLine("Enter an item (q to quit): ");
            user_input = Console.ReadLine();
            items.Add(user_input);
        }
        items.RemoveAt(items.Count - 1);
        DisplayItems(items); 
    }
    static void DisplayItems(List<string> items)
    {
        int number_items = items.Count;
        Console.WriteLine("Grocery List: "+"("+ number_items + " items)");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

    }
}