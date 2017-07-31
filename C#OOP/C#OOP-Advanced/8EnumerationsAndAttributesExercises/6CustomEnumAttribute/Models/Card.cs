using System;

public class Card : IComparable<Card>
{
    private readonly Rank _rank;
    private readonly Suit _cardSuit;


    public Card(string cardRank, string cardSuit)
    {
        Enum.TryParse(cardRank, out this._rank);
        Enum.TryParse(cardSuit, out this._cardSuit);
    }

    public int Power => (int) this._rank + (int) this._cardSuit;

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return this.Power.CompareTo(other.Power);
    }


    public override string ToString()
    {
        return $"Card name: {this._rank} of {this._cardSuit}; Card power: {this.Power}";
    }
}