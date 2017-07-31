using System;

public class Card : IComparable<Card>
{
    private readonly CardRank _cardRank;
    private readonly CardSuit _cardSuit;


    public Card(string cardRank, string cardSuit)
    {
        Enum.TryParse(cardRank, out this._cardRank);
        Enum.TryParse(cardSuit, out this._cardSuit);
    }

    public int Power => (int)this._cardRank + (int)this._cardSuit;

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return this.Power.CompareTo(other.Power);
    }


    public override string ToString()
    {
        return $"{this._cardRank} of {this._cardSuit}.";
    }
}