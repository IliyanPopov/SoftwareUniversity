using System;

public class Startup
{
    public static void Main()
    {
        Console.WriteLine("Card Ranks:");

        foreach (var rank in Enum.GetValues(typeof(CardRank)))
        {
            Console.WriteLine($"Ordinal value: {(int) rank}; Name value: {rank}");
        }
    }
}