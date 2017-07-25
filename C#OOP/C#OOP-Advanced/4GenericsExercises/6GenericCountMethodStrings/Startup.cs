using System;

public class Startup
{
    public static void Main()
    {
        IBox<string> items = new Box<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            items.Add(Console.ReadLine());
        }

        string itemToCompareWith = Console.ReadLine();

        Console.WriteLine(items.CompareWithEachElement(itemToCompareWith));

    }
}

