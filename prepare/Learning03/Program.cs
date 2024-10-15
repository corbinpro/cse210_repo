using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Console.WriteLine(first.GetFraction());
        Console.WriteLine(first.GetDecimal());
        
        Fraction second = new Fraction(5);
        Console.WriteLine(second.GetFraction());
        Console.WriteLine(second.GetDecimal());

        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.GetFraction());
        Console.WriteLine(third.GetDecimal()); 

        Fraction fourth = new Fraction(1, 3);
        Console.WriteLine(fourth.GetFraction()); 
        Console.WriteLine(fourth.GetDecimal());

        
    }
}