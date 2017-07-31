using System;

public class Startup
{
    public static void Main()
    {
        foreach (var suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach (var rank in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"{rank} of {suit}");
            }
        }
    }
}