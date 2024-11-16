using System;

class Program
{
    static void Main(string[] args)
    {
        //rectangle
        Rectangle rectangle = new Rectangle(5,10);
        rectangle._SetColor("blue");
        Console.WriteLine(rectangle._GetArea());
        Console.WriteLine(rectangle._GetColor());

        //square
        Square square = new Square(5);
        square._SetColor("green");
        Console.WriteLine(square._GetArea());
        Console.WriteLine(square._GetColor());

        //circle
        Circle circle = new Circle(5);
        circle._SetColor("yellow");
        Console.WriteLine(circle._GetArea());
        Console.WriteLine(circle._GetColor());
    }
}


public abstract class Shape
{
    private string _color;

    public Shape()
    {
        _color = "red";
    }

    public void _SetColor(string color)
    {
        _color = color;
    }

    public string _GetColor()
    {
        return _color;
    }

    public abstract double _GetArea();
}