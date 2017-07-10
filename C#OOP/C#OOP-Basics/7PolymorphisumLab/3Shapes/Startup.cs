using System;

public class Startup
{
    public static void Main()
    {
        Shape rect = new Rectangle(2, 3);
        Shape circle = new Circle(5);
        Console.WriteLine(rect.CalculatePerimeter());
        Console.WriteLine(rect.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());
    }
}

