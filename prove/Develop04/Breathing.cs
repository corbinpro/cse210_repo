public class Breathing : Activity
{
    public Breathing(int choice, int duration) : base(choice, duration)
    {
        Console.WriteLine(startMessage);
    }
}