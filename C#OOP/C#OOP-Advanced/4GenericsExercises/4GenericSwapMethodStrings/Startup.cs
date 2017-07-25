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
        var data = Console.ReadLine().Split();
        int index1 = int.Parse(data[0]);
        int index2 = int.Parse(data[1]);

        items.Swap(index1, index2);
        Console.WriteLine(items.ToString());
    }
}

