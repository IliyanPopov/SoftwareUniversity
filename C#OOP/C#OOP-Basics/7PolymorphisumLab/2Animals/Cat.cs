using System;

public class Cat : Animal
{
    public override string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood} " +
               $"{Environment.NewLine}MEEOW";
    }

    public Cat(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }
}

