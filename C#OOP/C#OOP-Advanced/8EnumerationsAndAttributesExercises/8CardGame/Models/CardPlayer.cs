using System.Collections.Generic;
using System.Linq;

public class CardPlayer
{
    public CardPlayer(string name)
    {
        this.Name = name;
        this.Cards = new List<Card>();
    }

    public string Name { get; }

    public List<Card> Cards { get; set; }

    public Card BiggestCard
    {
        get { return this.Cards.Max(); }
    }

}