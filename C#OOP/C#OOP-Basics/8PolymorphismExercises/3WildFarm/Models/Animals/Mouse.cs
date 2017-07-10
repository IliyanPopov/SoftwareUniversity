using System;

public class Mouse : Mamal
{
    public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "SQUEEEAAAK!";
    }

    public override void Eat(Food food)
    {
        Validator.VegetarianValidator(food, "Mouses");
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
