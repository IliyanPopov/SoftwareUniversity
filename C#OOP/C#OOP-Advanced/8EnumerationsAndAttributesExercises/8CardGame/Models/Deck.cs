using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    public Deck()
    {
        this.Cards = new List<Card>();
        AddAllCards();
    }

    private void AddAllCards()
    {
        foreach (var suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach (var rank in Enum.GetValues(typeof(CardRank)))
            {
                this.Cards.Add(new Card(rank.ToString(), suit.ToString()));
            }
        }
    }

    public bool CheckIfCardIsInDeck(Card card)
    {
        return this.Cards.Any(c => c.ToString() == card.ToString());
    }
    public IList<Card> Cards { get; private set; }

    public void RemoveCard(Card card)
    {
        var cardToRemove = this.Cards.FirstOrDefault(c => c.ToString() == card.ToString());
        this.Cards.Remove(cardToRemove);
    }

}

