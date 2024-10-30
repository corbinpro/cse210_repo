using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Activity
{
    private List<string> _startMessages = new List<string>
    {
        "This is a breathing exercise to help calm and focus your mind. It is the basis for many other meditation practices. \nYou must inhale with your stomach not your chest, for 6 seconds.\nAnd then exhale for 6 seconds. \nLet's begin.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.\nRead the prompt and then ponder for the prompted time. \nLet's begin.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\nList as many things as you can based on the prompt in the time allotted. \nLet's begin."
    };

    private int _duration = 0;

    private List<string> _endMessages = new List<string>
    {
        "You may now carry on with your day, task, or meditation.",
        "Remember these things throughout the day.",
        "Consider writing down this list next time and putting it somewhere you can see it."
    };

    public Activity(int choice, int duration)
    {
        string startMessage = _startMessages[choice];
        _duration = duration;
        string endMessage = _endMessages[choice];
    }


}