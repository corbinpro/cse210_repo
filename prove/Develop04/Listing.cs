using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> prompts = new List<string>
    {
        "List as many things as you can that make you happy.",
        "List as many things as you can that you are grateful for.",
        "List as many things as you can that you are proud of.",
        "List as many things as you can that you are looking forward to.",
        "List as many things as you can that you are excited about.",
        "List as many things as you can that you are thankful for.",
        "List as many things as you can that you are hopeful for.",
        "List as many things as you can that you are passionate about.",
        "List as many things as you can that you are interested in.",
        "List as many things as you can that you are curious about."
    };
    Random random = new Random();
    private int durationMathified = 0;

    public Listing(int choice, int duration) : base(choice, duration)
    {
        durationMathified = (int)Math.Ceiling((double)duration / 1);
    }

    public void _listingExcercise()
    {
        Console.Clear();
        Console.WriteLine("Let's Begin\n");
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        Thread.Sleep(4000);
        Animation animation = new Animation(durationMathified);
        animation._start();
    
    }
}