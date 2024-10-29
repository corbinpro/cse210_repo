using System;
using System.Threading;

class PirateSkullAnimation
{
    static void Main()
    {
        string[] frames = new string[]
        {






        
        };

        while (true)
        {
            foreach (string frame in frames)
            {
                Console.Clear();
                Console.WriteLine(frame);
                Thread.Sleep(150); // Adjust speed here
            }
        }
    }
}