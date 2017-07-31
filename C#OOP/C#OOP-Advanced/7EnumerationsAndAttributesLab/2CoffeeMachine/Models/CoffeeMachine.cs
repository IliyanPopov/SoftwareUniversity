using System;
using System.Collections.Generic;
using System.Text;

public class CoffeeMachine
{
    private CoffeePrice _coffeePrice;
    private CoffeeType _coffeeType;
    private Coin _coin;
    private int _coins;

    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public IList<CoffeeType> CoffeesSold { get; }

    public void BuyCoffee(string size, string type)
    {
        Enum.TryParse(size, out this._coffeePrice);
        Enum.TryParse(type, out this._coffeeType);

        if (this._coins >= (int)this._coffeePrice)
        {
            this.CoffeesSold.Add(this._coffeeType);
            this._coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Enum.TryParse(coin, out this._coin);
        this._coins += (int)this._coin;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var coffeeType in this.CoffeesSold)
        {
            sb.AppendLine(coffeeType.ToString());
        }

        return sb.ToString().Trim();
    }
}