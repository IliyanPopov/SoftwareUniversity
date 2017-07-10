using System;

public class Cat : Felime
{
    private string _breed;

    public string Breed
    {
        get { return this._breed; }
        set { this._breed = value; }
    }


    public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalName, animalType,
        animalWeight, livingRegion)
    {
        this.Breed = breed;
    }

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public override void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}