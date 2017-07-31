using System;

public class Startup
{
    public static void Main()
    {
        Console.WriteLine($"Card Suits:");
        foreach (var value in Enum.GetValues(typeof(Suit)))
        {
            Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
        }
    }
}

