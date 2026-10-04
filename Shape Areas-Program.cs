using System;
using System.Collections.Generic;

public class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5.0),       
            new Rectangle(4.0, 6.0) 
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Type: {shape.GetType().Name}, Area: {shape.CalculateArea():F2}");
        }
    }
}
