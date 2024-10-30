using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Animation animation = new Animation(2);
        animation._start(); 

        int choice = 0;

        while (choice != 4) 
        {
            Console.WriteLine("Please choose one of the following:\n1.Breathing Excercise\n2.Reflection Excercise,\n3.Listing Excercise\n4.Quit");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How long would you like to do this activity for? (in seconds)");
            int duration = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Breathing breathing = new Breathing(choice, duration);
            }
            else if (choice == 2)
            {
                
            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");            
            }
        }
    }

// class to run animation. takes int input for seconds animation should run


    
}