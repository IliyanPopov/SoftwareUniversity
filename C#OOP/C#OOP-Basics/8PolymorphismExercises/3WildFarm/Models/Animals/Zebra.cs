using System;

public class Zebra : Mamal
{
    public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "Zs";
    }

    public override void Eat(Food food)
    {
        Validator.VegetarianValidator(food, "Zebras");
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
