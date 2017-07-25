using System;

public class Startup
{
    public static void Main()
    {
        IBox<double> items = new Box<double>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            items.Add(double.Parse(Console.ReadLine()));
        }

        double itemToCompareWith = double.Parse(Console.ReadLine());

        Console.WriteLine(items.CompareWithEachElement(itemToCompareWith));
    }
}