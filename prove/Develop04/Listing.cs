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
        durationMathified = (int)Math.Ceiling((double)duration / 12);
    }

    public void _listingExcercise()
    {
        Console.WriteLine("Let's Begin");
        for (int i = 0; i < durationMathified; i++)    
            Console.WriteLine(prompts[random.Next(prompts.Count)]);
            Thread.Sleep(6000);
            Animation animation = new Animation(6);
            animation._start();
    
    }
}