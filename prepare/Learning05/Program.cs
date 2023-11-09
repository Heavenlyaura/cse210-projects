using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Square square = new(10, "brown");
        Rectangle rectangle = new(10, 20, "green");
        Circle circle = new(10, "purple");

        List<Shape> shapeList = new()
        {
            circle,
            rectangle,
            square
        };

        foreach (Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
            // Console.WriteLine();
        }

        


        string Scolor = square.GetColor();
        double Sarea = square.GetArea();

        double Rarea = rectangle.GetArea();
        string rcolor = rectangle.GetColor();

        double carea = circle.GetArea();
        string ccolor = circle.GetColor();


        // Console.WriteLine(Sarea);
        // Console.WriteLine(Scolor);
        
        // Console.WriteLine(Rarea);
        // Console.WriteLine(rcolor);
        
        // Console.WriteLine(ccolor);
        // Console.WriteLine(carea);
    }
}