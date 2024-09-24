using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of author of your favorite quote?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the quote?");
        string quote = Console.ReadLine();

        Console.WriteLine($"\"{quote}\" \n- {name}" );   
    }
}