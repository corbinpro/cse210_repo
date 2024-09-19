using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you numeric grade?");
        string score_input = Console.ReadLine();
        int score = int.Parse(score_input);

        if (score >= 90)
        {
            Console.WriteLine("Your letter grade is: A \nYou passed");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your letter grade is: B \nYou passed");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your letter grade is: C\nYou passed");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your letter grade is: D\nYou failed");
        }
        else
        {
            Console.WriteLine("Your letter grade is: F\nYou failed");
        }
    }
}