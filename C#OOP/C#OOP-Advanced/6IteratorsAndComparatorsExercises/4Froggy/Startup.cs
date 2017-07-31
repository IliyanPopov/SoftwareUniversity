using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var items = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Lake<int> lake = new Lake<int>(items);

        Console.WriteLine(string.Join(", ", lake));
    }
}

