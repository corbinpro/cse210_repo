using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("First name?");
        string first = Console.ReadLine();
        Console.WriteLine("Last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {first} {last}.");
    }
}