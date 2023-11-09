namespace Learning05;

public class Circle : Shape
{
    private double _piValue = Math.PI;
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _piValue * (_radius * _radius);
    }
}
