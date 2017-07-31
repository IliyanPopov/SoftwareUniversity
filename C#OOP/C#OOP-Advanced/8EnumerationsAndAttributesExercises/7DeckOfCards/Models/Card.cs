using System;

public class Card
{
    private readonly CardRank _cardRank;
    private readonly CardSuit _cardSuit;

    public int Power => (int)this._cardRank + (int)this._cardSuit;



    public Card(string cardRank, string cardSuit)
    {
        Enum.TryParse(cardRank, out this._cardRank);
        Enum.TryParse(cardSuit, out this._cardSuit);
    }

    public override string ToString()
    {
        return $"Card name: {this._cardRank} of {this._cardSuit}; Card power: {this.Power}";
    }
}