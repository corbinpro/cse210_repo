using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        int user_input = 1;
        float total = 0;

        do 
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            user_input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(user_input);

        } while (user_input != 0);

        numbers.RemoveAt(0);
        
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine("The average of the numbers is: " + total / numbers.Count);

    }
}