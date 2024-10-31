using System;
using System.Threading;

public class Breathing : Activity
{
    string inhale = "Inhale for 6 seconds when timer starts...";
    string exhale = "Exhale for 6 seconds when timer starts...";
    private float durationMathified = 0;
    public Breathing(int choice, int duration) : base(choice, duration)
    {
        durationMathified = duration / 12;
        durationMathified = (int)Math.Ceiling(durationMathified);
    }

    public void _breathingExcercise()
    {
        Console.WriteLine("Lets Begin");
        
        Thread.Sleep(2000);

        for (int i = 0; i < durationMathified; i++)    
            Console.WriteLine(inhale);
            Thread.Sleep(1000);
            Animation animation = new Animation(6);
            animation._start();
            Thread.Sleep(1000);

            Console.WriteLine(exhale);
            Thread.Sleep(1000);
            animation = new Animation(6);
            animation._start();     
            Thread.Sleep(1000);
    }
}