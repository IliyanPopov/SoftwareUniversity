using System;

public class Startup
{
    public static void Main()
    {
        IBox<int> items = new Box<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            items.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(items.ToString());
    }
}

