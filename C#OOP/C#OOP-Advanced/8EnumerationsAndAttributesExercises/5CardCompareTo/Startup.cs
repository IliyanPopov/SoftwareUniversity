using System;

public class Startup
{
    public static void Main()
    {
        string card1Rank = Console.ReadLine();
        string card1Suit = Console.ReadLine();
        Card card1 = new Card(card1Rank, card1Suit);

        string card2Rank = Console.ReadLine();
        string card2Suit = Console.ReadLine();
        Card card2 = new Card(card2Rank, card2Suit);

        var result = card1.CompareTo(card2);

        if (result == 1)
        {
            Console.WriteLine(card1.ToString());
        }

        else if (result == -1)
        {
            Console.WriteLine(card2.ToString());
        }
        else
        {
            Console.WriteLine(card1.ToString());
        }
    }
}