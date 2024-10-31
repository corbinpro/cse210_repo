using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Animation
{
    private int _seconds = 0;
    private string[] filepaths = new string[]
    {
        "frames/frame1.txt",
        "frames/frame2.txt",
        "frames/frame3.txt",
        "frames/frame4.txt",
        "frames/frame5.txt",
        "frames/frame6.txt",
    };

    private List<string> frames = new List<string>();

    private void _read()
    {
        foreach (string filePath in filepaths)
        {
            frames.Add(File.ReadAllText(filePath));
        }
    }

    public Animation(int seconds)
    {
        _seconds = seconds;
        Console.Clear();
        _read();
    }

    public void _start()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string frame in frames)
            {
                if (DateTime.Now >= endTime)
                    break;

                Console.Clear();
                Console.WriteLine(frame);
                Thread.Sleep(1000);
            }
        }
    }
}