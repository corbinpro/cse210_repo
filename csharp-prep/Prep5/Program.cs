using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int user_number = PromptUserNumber();
        int squared_number = SquareNumberO(user_number);
        DisplayResult(name, user_number, squared_number);

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    static int SquareNumberO(int user_number)
    {
        int number = user_number;
        return number * number;
    }

    static void DisplayResult(string name, int user_number, int squared_number)
    {
        Console.WriteLine(name + ", the square of your favorite number is " + squared_number);

    }
    }
}