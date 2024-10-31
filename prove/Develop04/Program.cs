using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4) 
        {
            Console.WriteLine("Please choose one of the following:\n1.Breathing Excercise\n2.Reflection Excercise,\n3.Listing Excercise\n4.Quit");
            choice = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine("How long would you like to do this activity for? (in seconds, minumum 12 seconds)");
            int duration = Convert.ToInt32(Console.ReadLine());
            if (duration <12)
            {
                duration = 12;
            }

            if (choice == 1)
            {
                Breathing breathing = new Breathing(choice -1, duration);
                breathing._start();
                breathing._breathingExcercise();
                breathing._end();
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection(choice -1, duration);
                reflection._start();
                reflection._reflectionExcercise();
                reflection._end();
            }
            else if (choice == 3)
            {
                Listing listing = new Listing(choice -1, duration);
                listing._start();
                listing._listingExcercise();
                listing._end();   
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");            
            }
        }
    }




    
}