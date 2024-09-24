using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1,101);
        Console.WriteLine("I have a number between 1 and 100. Can you guess it?");
        int guess = 0;
        while (guess != magic_num)
        {
            Console.WriteLine("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < magic_num)
            {
                Console.WriteLine("Too low. Try again.");
            }
            else if (guess > magic_num)
            {
                Console.WriteLine("Too high. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number!");
            }
        }

    }
}