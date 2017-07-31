using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        string player1Name = Console.ReadLine();
        CardPlayer player1 = new CardPlayer(player1Name);
        string player2Name = Console.ReadLine();
        CardPlayer player2 = new CardPlayer(player2Name);

        Deck deck = new Deck();

        while (player1.Cards.Count < 5)
        {
            var data = Console.ReadLine().Split();
            CardRank cardRank;
            CardSuit cardSuit;
            bool isCardRankValid = Enum.TryParse(data[0], out cardRank);
            bool isCardSuitValid = Enum.TryParse(data[2], out cardSuit);

            if (isCardRankValid && isCardSuitValid)
            {
                Card card = new Card(cardRank.ToString(), cardSuit.ToString());

                if (deck.CheckIfCardIsInDeck(card))
                {
                    player1.Cards.Add(card);
                    deck.RemoveCard(card);
                }

                else
                {
                    Console.WriteLine($"Card is not in the deck.");
                }
            }
            else
            {
                Console.WriteLine($"No such card exists.");
            }
        }


        while (player2.Cards.Count < 5)
        {
            var data = Console.ReadLine().Split();
            CardRank cardRank;
            CardSuit cardSuit;
            bool isCardRankValid = Enum.TryParse(data[0], out cardRank);

            bool isCardSuitValid = Enum.TryParse(data[2], out cardSuit);

            if (isCardRankValid && isCardSuitValid)
            {
                Card card = new Card(cardRank.ToString(), cardSuit.ToString());
                if (deck.CheckIfCardIsInDeck(card))
                {
                    player2.Cards.Add(card);
                    deck.RemoveCard(card);
                }
                else
                {
                    Console.WriteLine($"Card is not in the deck.");
                }
            }
            else
            {
                Console.WriteLine($"No such card exists.");
            }
        }

        if (player1.BiggestCard.CompareTo(player2.BiggestCard) == 1)
        {
            Console.WriteLine($"{player1.Name} wins with {player1.BiggestCard}");
        }

        if (player1.BiggestCard.CompareTo(player2.BiggestCard) == -1)
        {
            Console.WriteLine($"{player2.Name} wins with {player2.BiggestCard}");
        }
    }
}