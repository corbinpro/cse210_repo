public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double _GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}