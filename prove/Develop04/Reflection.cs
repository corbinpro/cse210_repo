using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
        "Reflect on a time when you showed strength and resilience.",
        "Reflect on the good things in your life.",
        "Reflect on a time when you showed kindness to someone.",
        "Reflect on a time when you were proud of yourself.",
        "Reflect on a time when you were able to overcome a challenge.",
        "Reflect on a time when you were able to help someone.",
        "Reflect on a time when you were able to learn something new.",
        "Reflect on a time when you were able to forgive someone.",
        "Reflect on a time when you were able to let go of something.",
        "Reflect on a time when you were able to make a positive change in your life."
    };
    Random random = new Random();
    private int durationMathified = 0;

    public Reflection(int choice, int duration) : base(choice, duration)
    {
        durationMathified = (int)Math.Ceiling((double)duration / 12);
    }

    public void _reflectionExcercise()
    {
        Console.WriteLine("Let's Begin");
        for (int i = 0; i < durationMathified; i++)    
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            Thread.Sleep(6000);
            Animation animation = new Animation(6);
            animation._start();
    
    }
}